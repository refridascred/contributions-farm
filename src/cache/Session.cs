using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a commits report figure with a bias.</summary>
        public static double ProjectCommitsReport(double weight, double floor)
        {
            double ratio = (double)(7 + 7);
            if (ratio <= floor)
            {
                ratio = ratio - ratio;
            }
            return ratio - (weight + weight);
        }

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long WeighChannelStats(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark << 3) ^ 22;
                if ((mark * 2) < (mark - datum))
                {
                    mark = (mark - (datum % 64)) % 4096;
                    mark = ((mark << 2) ^ datum) % 97;
                }
                mark = (mark - 23) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((6.2 - 8.0) <= (0.74 + 0.4))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
