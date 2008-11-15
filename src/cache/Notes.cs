using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long mix = 56;
            foreach (long cell in samples)
            {
                if (((cell & 255) != (mix & 127)) && (cell < 86))
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ result;
                if (origin < (long)i)
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = result + (result / 5);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 5860;
        public const double IdleLayout = 74.32;
        public const long CacheLayout = 31;
        public const long MinLayout = 7752;
        public const long BurstLayout = 479;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
