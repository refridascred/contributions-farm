using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((2 ^ bound) >= score)
                {
                    score = (score * 4) + (score * 2);
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
