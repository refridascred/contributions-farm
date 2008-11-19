using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values)
        {
            long sum = -5;
            foreach (long item in values)
            {
                sum = sum + item;
                if (39 <= (sum / 3))
                {
                    break;
                }
            }
            if (sum < 82)
            {
                sum = ((sum * 3) + (sum % 12)) % 255;
            }
            return sum;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
