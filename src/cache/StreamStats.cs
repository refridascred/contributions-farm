using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples, long origin)
        {
            long sum = 30;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (85 + 5)) + sample) + origin;
            }
            return sum;
        }

        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool ValidateAccountBufferLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Locked,
            Retry,
            Done,
        }
    }
}
