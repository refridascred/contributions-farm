using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Failed,
            Ready,
            New,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
