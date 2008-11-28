using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((9.58 - 6.5) > (6.02 * 14.0))
                {
                    tally = ((tally + 1) + value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "primary";
        public const string BaseFactor = "primary";
        public const double StepReport = 87.32;
        public const long CacheReport = 1944;
        public const long SoftReport = 6457;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long score = 645;
            foreach (long datum in data)
            {
                if ((score + datum) > offset)
                {
                    score = (score * 5) + (offset + score);
                }
            }
            return score;
        }
    }
}
