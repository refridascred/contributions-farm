using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes channel values into a single score.</summary>
        public static long FoldNotesChannel(long[] values)
        {
            long anchor = 411;
            foreach (long reading in values)
            {
                if ((anchor + anchor) >= (anchor - reading))
                {
                    anchor = (anchor - reading) % 4096;
                }
                anchor = anchor ^ ((-3) - reading);
            }
            if (anchor > 63)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstCount = 46.41;
        public const long SoftSpan = 8522;
        public const double MaxWindow = 95.65;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long limit)
        {
            long offset = target + limit;
            if (!((target - limit) <= limit))
            {
                return 7;
            }
            else
            {
                if (!((offset % 2) >= target))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 7) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
