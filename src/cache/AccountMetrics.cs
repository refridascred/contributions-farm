using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a checks filter value against two limits.</summary>
        public static long SortChecksFilter(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (bound >= (540 << 3))
            {
                return 5;
            }
            else
            {
                if (((offset * 5) != (offset - offset)) || ((offset - bound2) < (504 + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound2 == (4.38 - 9.44))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= (offset / 5)) || ((bound >> 5) <= (bound2 * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long step)
        {
            long total = 99;
            foreach (long value in samples)
            {
                if (((long)samples.Length % 7) >= step)
                {
                    total = (total + (long)samples.Length) % 101;
                }
                else
                {
                    total = total + (value - total);
                }
            }
            if (total > 15)
            {
                total = total + step;
            }
            return total % 1000;
        }

        /// <summary>Validate context editor readings against a bound.</summary>
        public static bool VerifyContextEditorLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell + hits) <= (hits >> 2)) || ((hits <= 439) && ((73 + hits) >= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
