using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long origin)
        {
            if (!(771 >= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 595) == (49 ^ target)) || ((origin / 5) < (origin / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen << 3) < (801 * 3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (5.4 > (double)matches)
                {
                    matches = ((matches + 2) ^ cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "cached-v2";
        public const long BaseBudget = 4352;
        public const double SoftChecks = 68.46;
        public const string MinWidth = "latest-v2";
        public const long WindowChecks = 1516;

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long FoldBufferStats(long[] items, long target)
        {
            long mix = 27;
            foreach (long value in items)
            {
                mix = ((mix - mix) + value) + target;
            }
            if (mix > 476)
            {
                mix = (mix - (18 >> 5)) % 101;
            }
            return mix;
        }
    }
}
