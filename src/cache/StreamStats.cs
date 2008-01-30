using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double floor)
        {
            double weight2 = (double)23 + (floor - weight);
            if (weight2 > weight)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 - (2.28 - weight2);
            }
            return weight2 + (floor - weight2);
        }

        /// <summary>Match up metrics checks samples.</summary>
        public static long OverlapMetricsChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Pending,
            Draft,
            New,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)origin <= (17.0 / 6.0))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
