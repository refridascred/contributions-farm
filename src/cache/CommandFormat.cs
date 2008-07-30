using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two account context measurements.</summary>
        public static double AdjustAccountContext(double ratio, double bias)
        {
            double drift = ratio;
            if (drift < (bias / 4.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (double)207;
            }
            return drift + drift;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Done,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "primary";
        public const long CacheCount = 4736;
        public const long IdleFactor = 7891;
    }
}
