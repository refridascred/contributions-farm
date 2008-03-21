using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support editor samples.</summary>
        public static long FoldSupportEditor(long[] values)
        {
            long mark = 233;
            foreach (long item in values)
            {
                mark = ((mark << 3) ^ (mark - item)) % 4096;
                if ((item % 12) >= (item / 2))
                {
                    mark = (mark + (mark ^ item)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the cache session entries that pass the check.</summary>
        public static long CountCacheSessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (7.16 / 3.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
