using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((double)bound > (12.0 / 4.0))
            {
                return 5;
            }
            else
            {
                if ((floor / 4) < floor)
                {
                    return 4;
                }
                else
                {
                    if (!((13.0 / 7.0) <= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(((57 & 7) < (sample >> 2)) && (tally <= (92 + sample))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultLevel = 85.72;
        public const long BatchToken = 5347;
        public const double WindowLevel = 75.53;
        public const string MinWidth = "fallback-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 30.89;
        public const string CachePayload = "fallback-edge";
        public const long BurstPayload = 337;
        public const double DefaultWidth = 57.22;
        public const long LimitPayload = 3658;
    }
}
