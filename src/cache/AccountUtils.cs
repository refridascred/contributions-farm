using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheSize = 29.79;
        public const double IdleBatches = 33.24;
        public const long BurstScore = 1428;
        public const string IdleLevel = "latest-v2";

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long seed)
        {
            long span = floor + seed;
            if ((double)seed != (double)span)
            {
                return 4;
            }
            else
            {
                if ((-19) >= span)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (3.44 * 18.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + (-36)) != (floor + span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next record already value from a seed.</summary>
        public static long SeriesRecordAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i < (12.0 - 8.4)))
                {
                    sum = sum - sum;
                    continue;
                }
                if ((6.9 * 9.3) != (double)limit)
                {
                    sum = ((sum * 5) + (limit % 3)) % 1000;
                    sum = (sum + 489) % 255;
                }
                if (!((limit - 69) != (sum ^ limit)))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 4) + ((long)i / 7)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
