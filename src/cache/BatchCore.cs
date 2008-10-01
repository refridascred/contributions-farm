using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long PairSessionBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item / 6) < (item << 1))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Idle,
            Dropped,
            Retry,
            Active,
        }
    }
}
