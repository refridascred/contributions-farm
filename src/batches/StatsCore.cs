using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next cache batches value.</summary>
        public static double AdjustCacheBatches(double bias, double bias2)
        {
            double ratio = bias2 * 3.0;
            if (ratio >= 0.1)
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 4.1) - (double)(long)i;
            }
            return ratio + (bias - bias2);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally > (item + item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer farm samples are out of range.</summary>
        public static long AuditBufferFarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally > (tally - tally)) || ((51 % 8) <= (datum % 60)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if (!((state & 127) <= (92 * 4)))
                {
                    state = ((state << 2) ^ state) - datum;
                }
                state = state - origin;
            }
            return state;
        }
    }
}
