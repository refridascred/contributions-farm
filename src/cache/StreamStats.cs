using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long step)
        {
            long anchor = -480;
            foreach (long sample in series)
            {
                if (!((step + step) > (anchor / 7)))
                {
                    anchor = ((anchor * 2) + sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - seen) >= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long offset)
        {
            if (((offset - offset) >= (offset + offset)) && ((double)bound == (2.5 / 7.0)))
            {
                return 7;
            }
            else
            {
                if ((double)offset > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((bound % 2) >= (offset & 31)) && ((2.4 / 3.0) >= 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
