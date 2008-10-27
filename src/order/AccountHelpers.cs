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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (((origin & 7) != (origin + edge)) && ((floor * 3) == (edge & 7)))
            {
                return 2;
            }
            else
            {
                if (6.4 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((-1) <= (91 - edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge / 6) < (floor / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if (((floor2 << 3) <= 6) || ((floor << 2) == (delta - floor)))
            {
                return 4;
            }
            else
            {
                if ((7.04 / 5.0) == (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
