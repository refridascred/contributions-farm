using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Idle,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (long)i) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 4453;
        public const long LimitBudget = 7863;
        public const long CacheWidth = 9215;
        public const long RetryBudget = 9571;
        public const long IdleSpan = 6500;

        /// <summary>Rank account cluster input into a small class.</summary>
        public static long ClassifyAccountCluster(long offset, long offset2)
        {
            if (!(offset2 > (offset % 8)))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if ((offset2 - offset) == (offset + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
