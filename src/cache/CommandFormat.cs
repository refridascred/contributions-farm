using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score ^ ((long)i >> 4)) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                long edge = (7 + (long)i) & 15;
                mark = (mark * 4) + (edge >> 1);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Ready,
            Idle,
            Synced,
        }
    }
}
