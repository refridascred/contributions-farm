using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit support metric readings against a rule.</summary>
        public static long AuditSupportMetricHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)floor >= 8.0)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Done,
            Active,
            Synced,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (offset <= (offset + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double weight2 = (double)330 / 6.0;
            if (weight2 > floor)
            {
                weight2 = weight2 - 4.3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (9.1 - weight);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] data, long offset)
        {
            long score = 17;
            foreach (long reading in data)
            {
                score = ((score ^ (score >> 1)) - reading) - offset;
            }
            if (score > 41)
            {
                score = (score * 2) + 23;
            }
            return score;
        }
    }
}
