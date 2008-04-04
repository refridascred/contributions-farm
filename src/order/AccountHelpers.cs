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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 845;
            foreach (long entry in levels)
            {
                if ((double)5 > (double)anchor)
                {
                    anchor = (anchor * 4) + (entry << 3);
                    anchor = anchor - anchor;
                }
                if ((232 ^ anchor) <= (anchor - 7))
                {
                    anchor = (anchor + (anchor & 63)) % 97;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
