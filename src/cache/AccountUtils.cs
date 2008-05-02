using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long target)
        {
            long slot = seed + target;
            if ((13.0 - 1.0) < (double)seed)
            {
                return 7;
            }
            else
            {
                if (!((target - slot) == (8 + slot)))
                {
                    return 4;
                }
                else
                {
                    if (((0.75 + 9.5) <= (double)seed) || ((slot << 1) >= (target + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
