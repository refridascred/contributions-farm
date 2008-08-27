using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                }
                if ((686 > bound) || (bound <= score))
                {
                    score = score ^ (bound ^ 8);
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (long)i) % 101;
                }
                score = (score << 2) ^ (bound & 255);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = result + (752 + 145);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
