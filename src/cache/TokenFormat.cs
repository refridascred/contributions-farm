using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of payload cluster readings.</summary>
        public static long ComparePayloadClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long AuditGraphMetricsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1 ^ 0) <= value)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double AdjustEditorFarm(double ratio, double span)
        {
            double load = (6.0 + ratio) - (ratio * 1.44);
            return load + (span / 7.0);
        }
    }
}
