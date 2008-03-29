using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long CountBatchChannelMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (364 + reading))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
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
