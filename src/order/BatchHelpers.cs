using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 177;
            foreach (long cell in values)
            {
                if (score <= (score + score))
                {
                    score = (score ^ ((-6) * 4)) - cell;
                }
            }
            if (score < 2)
            {
                score = score ^ (8 % 97);
            }
            return score % 1000;
        }

        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool GuardContributiRouteRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                if (cell <= (mix + mix))
                {
                    mix = (mix << 3) ^ (cell - mix);
                }
                else
                {
                    mix = (mix - (mix >> 3)) % 1000;
                }
            }
            return mix;
        }
    }
}
