using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Pending,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Project the next cluster already value.</summary>
        public static double BlendClusterAlready(double ratio, double floor)
        {
            double ratio2 = (double)(77 ^ 2);
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + ratio) - (double)(long)i) + floor;
            }
            return ratio2 - (ratio * 0.98);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell + 9))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Pending,
            Locked,
            Retry,
            Active,
        }
    }
}
