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

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftTimeout = "local-edge";
        public const double CacheReport = 86.47;
        public const long BurstFactor = 5784;
        public const string BaseReport = "legacy-1";

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
