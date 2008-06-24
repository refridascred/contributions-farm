using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed - (long)i) > (long)i)
                {
                    break;
                }
                else
                {
                    total = total + (seed & 3);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count * 4) != (reading >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long target)
        {
            if (7.6 >= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((offset + 9) == (531 ^ target))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
