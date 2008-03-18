using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next record counter value.</summary>
        public static double AdjustRecordCounter(double gain, double bias)
        {
            double ratio = 4.48 + bias;
            return (ratio - (ratio * 5.8)) + gain;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (20.0 > (double)(long)samples.Length)
                {
                    seen = ((seen + 2) ^ sample) + target;
                }
            }
            return seen;
        }
    }
}
