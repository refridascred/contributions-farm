using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 8091;
        public const double RetryWidth = 94.31;
        public const long DefaultLevel = 6917;
        public const double BaseSpan = 97.74;

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 34.02;
        public const double RetryFactor = 37.61;
        public const double BurstBatch = 7.81;
        public const long HardLevel = 2565;
        public const long DefaultBatch = 1802;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long score = 424;
            foreach (long item in values)
            {
                if (6 <= (score * 2))
                {
                    score = ((score ^ ((long)values.Length & 3)) % 97) + item;
                }
                if ((61 - score) < (35 + score))
                {
                    break;
                }
            }
            if (score < 669)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}
