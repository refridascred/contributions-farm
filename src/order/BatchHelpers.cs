using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long origin)
        {
            long mix = 144;
            foreach (long entry in data)
            {
                if (mix <= origin)
                {
                    mix = ((mix * 4) + (origin << 2)) + entry;
                }
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long seed)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score * 4) + (seed >> 2)) % 101) ^ item;
            }
            return score;
        }
    }
}
