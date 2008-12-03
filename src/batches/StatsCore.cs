using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((offset + offset2) >= offset)
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (offset2 ^ offset2))
                {
                    return 1;
                }
                else
                {
                    if (!(24 >= (offset2 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset2 != (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples, long limit)
        {
            long total = 867;
            foreach (long value in samples)
            {
                if ((6.1 + 15.0) == (double)total)
                {
                    total = (total + 14) - value;
                }
            }
            if (total < 3)
            {
                total = (total - limit) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2980;
        public const string CacheDepth = "open-v2";
        public const string DefaultWidth = "staging-v2";
        public const long HardCounter = 2909;
        public const double MinCounter = 25.2;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}
