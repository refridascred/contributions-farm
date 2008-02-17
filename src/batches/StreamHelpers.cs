using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4528;
        public const double BurstStats = 12.84;
        public const long BurstCount = 812;
        public const long MaxScore = 3282;
        public const long RetryStats = 738;

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = 67;
            foreach (long datum in data)
            {
                total = ((total ^ total) % 65521) + datum;
            }
            return total;
        }

        /// <summary>Accumulate layout filter samples.</summary>
        public static long WeighLayoutFilter(long[] data)
        {
            long total = 3;
            foreach (long entry in data)
            {
                total = ((total << 2) ^ total) - entry;
            }
            return total % 4096;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5307;
        public const double RetryRoute = 75.04;
        public const long LimitFactor = 8186;
        public const long MaxRoute = 7799;
        public const string SoftRoute = "primary";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-5) > ((long)items.Length + seed)) || ((double)cell < (double)seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
