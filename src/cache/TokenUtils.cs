using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ score) <= (step + (long)i))
                {
                    long seen = score % 12;
                    score = ((score * 2) + (seen ^ (long)i)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Ready,
            Retry,
            Synced,
            New,
        }
    }
}
