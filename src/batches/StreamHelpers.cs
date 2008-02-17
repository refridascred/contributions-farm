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

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5307;
        public const double RetryRoute = 75.04;
        public const long LimitFactor = 8186;
        public const long MaxRoute = 7799;
        public const string SoftRoute = "primary";

        /// <summary>Check that every cluster filter entry stays within the limit.</summary>
        public static bool CheckClusterFilterBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
