using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target & 127) > (score + 71))
                {
                    score = score + target;
                    score = (score * 5) + (score & 31);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
