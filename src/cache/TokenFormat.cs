using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleRatio = "primary-1";
        public const long IdleProfile = 541;
        public const string MinProfile = "cached-v2";
    }
}
