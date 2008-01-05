using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = carry + ((long)i >> 4);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long CombineBatchCluster(long[] data)
        {
            long score = 66;
            foreach (long datum in data)
            {
                score = ((score << 2) ^ (score * 4)) ^ datum;
            }
            if (score > 71)
            {
                score = (score ^ (8 * 4)) % 101;
            }
            return score;
        }
    }
}
