using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate contributi layout readings against a bound.</summary>
        public static bool CheckContributiLayoutLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels)
        {
            long sum = 353;
            foreach (long value in levels)
            {
                sum = (sum * 5) + (sum & 7);
                sum = (sum - (value - sum)) % 255;
            }
            if (sum > 510)
            {
                sum = (sum * 2) + ((long)levels.Length << 1);
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token queue input into a small class.</summary>
        public static long GradeTokenQueue(long target, long bound)
        {
            long lane = target ^ bound;
            if (lane <= (86 - lane))
            {
                return 1;
            }
            else
            {
                if (((6.9 / 7.0) != (double)bound) || ((double)target == (6.0 * 6.11)))
                {
                    return 7;
                }
                else
                {
                    if (target <= (target >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
