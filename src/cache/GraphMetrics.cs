using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > (tally ^ entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= floor)
            {
                gain2 = gain2 - (gain + gain2);
            }
            else
            {
                gain2 = gain2 + (gain - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (double)(-38)) + (double)(long)i;
            }
            return gain2 - (2.9 - gain2);
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
