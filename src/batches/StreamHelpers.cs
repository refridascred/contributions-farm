using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 32.53;
        public const double MinTimeout = 57.28;
        public const long IdleInterval = 8713;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of support report entries.</summary>
        public static long TallySupportReport(long[] data)
        {
            long carry = 987;
            foreach (long entry in data)
            {
                if (((entry + entry) <= entry) || ((double)entry >= 14.0))
                {
                    carry = (carry + (entry << 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCount = "fallback";
        public const long SoftLevel = 423;
        public const long BatchCluster = 4205;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Synced,
        }
    }
}
