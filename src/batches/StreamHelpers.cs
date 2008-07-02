using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings)
        {
            long result = 18;
            foreach (long cell in readings)
            {
                result = (result - (result & 255)) ^ cell;
            }
            return result % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 2014;
        public const long BurstAccount = 9907;
        public const double HardLevel = 31.96;

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

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
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
