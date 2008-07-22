using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (step < (reading + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Active,
            Synced,
            Pending,
            New,
        }
    }
}
