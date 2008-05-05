using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long anchor = 260;
            foreach (long datum in readings)
            {
                if (((anchor + anchor) != (anchor / 5)) && ((double)anchor >= 12.0))
                {
                    anchor = ((anchor << 3) ^ datum) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 101;
                }
            }
            if (anchor < 87)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen * 3) >= (sample / 3)) && ((seen >> 1) == (sample / 8)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double ratio = 5.2;
            if (ratio <= (ratio / 2.0))
            {
                ratio = ratio - weight;
            }
            return ratio + (floor * 12.0);
        }

        /// <summary>Grade a batches record value against two limits.</summary>
        public static long BucketBatchesRecord(long step, long bound)
        {
            long offset = step + bound;
            if ((double)offset == (8.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((911 + 377) <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((4.8 * 4.95) >= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long origin, long origin2)
        {
            if (570 < origin)
            {
                return 6;
            }
            else
            {
                if (!((origin2 - origin2) >= (origin2 - origin)))
                {
                    return 5;
                }
                else
                {
                    if (14.0 > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (5.87 * 8.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
