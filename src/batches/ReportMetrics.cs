using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((286 - seed2) <= (3 / 4))
            {
                return 7;
            }
            else
            {
                if (prev <= (prev * 2))
                {
                    return 3;
                }
                else
                {
                    if (!((double)prev <= 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset & 63) == ((long)i ^ mark))
                {
                    mark = (mark - mark) % 1000;
                    mark = (mark ^ mark) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "legacy-v2";
        public const long WindowAccount = 2315;
        public const string IdleCount = "staging-v2";
        public const double MinSpan = 45.6;
        public const double HardAccount = 70.28;
    }
}
