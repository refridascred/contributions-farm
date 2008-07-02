using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long seed)
        {
            long cur = offset ^ seed;
            if (!((seed % 7) < (seed - offset)))
            {
                return 3;
            }
            else
            {
                if ((offset / 2) != (seed * 4))
                {
                    return 4;
                }
                else
                {
                    if ((cur > offset) || ((offset * 2) <= (offset + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels, long seed)
        {
            long carry = 35;
            foreach (long value in levels)
            {
                if ((value & 7) != (value + carry))
                {
                    carry = ((carry * 5) + (24 - carry)) + seed;
                }
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "alpha-edge";
        public const long BaseScore = 8054;
        public const string BasePayload = "alpha";
        public const long IdlePayload = 1604;
        public const string BaseBudget = "fallback-1";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
