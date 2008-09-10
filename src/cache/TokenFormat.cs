using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }
    }
}
