using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((seed << 1) != (step2 << 3))
            {
                return 3;
            }
            else
            {
                if (((double)seed >= (5.8 + 6.91)) || ((9.8 + 4.0) < (double)step))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) >= (seed & 63)) && ((step2 << 2) < step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank graph command input into a small class.</summary>
        public static long SortGraphCommand(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((46 & 63) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((step2 ^ 19) <= (step * 2))
                {
                    return 3;
                }
                else
                {
                    if ((4 + floor) >= step2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value != (14.0 * 3.39))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score + score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 7268;
        public const double CacheSupport = 79.63;
        public const double WindowRatio = 86.12;
        public const string HardTimeout = "fallback";
        public const long DefaultSupport = 8248;

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
