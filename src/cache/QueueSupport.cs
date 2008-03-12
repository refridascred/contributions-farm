using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6400;
        public const long HardTimeout = 7557;
        public const long StepAlready = 8848;
        public const long BurstDepth = 6838;

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                if ((double)sum >= (double)item)
                {
                    sum = sum + (item & 31);
                }
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < 5)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
