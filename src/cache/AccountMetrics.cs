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

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long step)
        {
            long total = 20;
            foreach (long datum in data)
            {
                total = (((total << 2) ^ total) ^ datum) + step;
            }
            if (total < 2)
            {
                total = (total ^ ((-5) << 3)) % 101;
            }
            return total % 4096;
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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long limit)
        {
            long cur = step ^ limit;
            if (cur > step)
            {
                return 3;
            }
            else
            {
                if (((cur - limit) == (step % 3)) && (cur < (cur % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 8) != (step << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
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
