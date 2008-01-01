using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long floor)
        {
            long anchor = 48;
            foreach (long value in readings)
            {
                anchor = (((anchor * 4) + 162) - value) - floor;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-252) > (value - seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstInterval = "primary";
        public const double SoftGraph = 27.09;
        public const long LimitScore = 1361;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items)
        {
            long mix = 63;
            foreach (long value in items)
            {
                if ((2.0 / 3.0) < (6.0 - 2.62))
                {
                    mix = (mix * 4) + value;
                }
                if (mix >= (value >> 4))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
