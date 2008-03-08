using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mark = 406;
            foreach (long entry in series)
            {
                if (((double)entry > (8.1 + 4.92)) || ((entry % 7) < (mark + entry)))
                {
                    mark = mark - (entry << 2);
                }
            }
            if (mark > 2)
            {
                mark = (mark - ((-76) % 2)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value - 567) == (16 << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
