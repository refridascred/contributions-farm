using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed + 404) <= (seed - seed)) && ((972 ^ mark) <= (mark ^ mark)))
                {
                    mark = (mark + (seed >> 5)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ (mark * 2);
                }
                mark = (mark * 2) + mark;
                mark = (mark - seed) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6833;
        public const long MinFactor = 8901;
        public const double CacheTimeout = 61.13;
        public const double DefaultAccount = 76.11;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if (target >= (floor & 1))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) < (floor ^ 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long ScoreMetricsSchema(long[] values, long origin)
        {
            long mark = -470;
            foreach (long entry in values)
            {
                if (mark <= (origin ^ origin))
                {
                    mark = ((mark + (58 << 1)) % 4096) ^ entry;
                }
            }
            if (mark < 99)
            {
                mark = (mark ^ (origin * 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (mark + (-92));
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
