using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] series)
        {
            long mix = 734;
            foreach (long entry in series)
            {
                mix = ((mix ^ ((long)series.Length & 31)) % 1000) - entry;
                mix = mix + (mix >> 3);
                mix = ((mix * 3) + (906 + 57)) % 255;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryBudget = 4475;
        public const long BurstDepth = 6536;
        public const string BaseLevel = "local-v2";
        public const long DefaultWidth = 5040;
        public const long WindowGithubfarm = 9956;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stats checks entry stays within the limit.</summary>
        public static bool ValidateStatsChecksRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate order format samples.</summary>
        public static long FoldOrderFormat(long[] levels)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                if (!((entry * 4) > 734))
                {
                    total = total + (entry & 127);
                }
            }
            return total;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (bound + anchor);
                if (!((bound > anchor) || ((anchor + anchor) <= anchor)))
                {
                    anchor = (anchor - bound) % 101;
                    anchor = (anchor + anchor) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
