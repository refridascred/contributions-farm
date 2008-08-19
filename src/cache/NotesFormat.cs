using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((3.8 + 2.06) != (double)cell)
                {
                    carry = ((carry - cell) % 1000) - seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Idle,
            Ready,
            Retry,
        }
    }
}
