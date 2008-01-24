using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the cache farm entries that pass the check.</summary>
        public static long CountCacheFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) == (sample + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long seed)
        {
            long span = limit - seed;
            if (((8 + 621) > seed) && ((6.0 / 4.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if ((9.72 - 8.5) >= (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((seed - limit) < seed)
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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values)
        {
            long sum = 439;
            foreach (long datum in values)
            {
                if (!((datum < (sum / 9)) && ((datum * 2) > (sum % 7))))
                {
                    sum = ((sum << 3) ^ (datum - (long)values.Length)) % 255;
                    sum = (sum + (datum - 31)) % 101;
                }
                if (((90 + datum) < (1 - sum)) || (sum > (sum / 2)))
                {
                    sum = sum + (sum & 7);
                }
            }
            return sum % 65521;
        }
    }
}
