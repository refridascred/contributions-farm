using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long target)
        {
            long prev = bound ^ target;
            if ((7.0 / 2.0) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (target >= (prev % 60))
                {
                    return 0;
                }
                else
                {
                    if (!((prev >> 2) > prev))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((prev >> 5) < (370 - 2)) && ((636 & 15) > (prev + bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 7116;
        public const long BurstDepth = 4217;
        public const long CacheRatio = 5804;
        public const long CacheScore = 1239;
        public const string RetryContext = "strict-v2";

        /// <summary>Combine batches metric values into a single score.</summary>
        public static long DigestBatchesMetric(long[] series)
        {
            long anchor = 412;
            foreach (long sample in series)
            {
                if (((sample << 2) >= (sample + anchor)) && ((anchor * 2) >= (695 << 3)))
                {
                    anchor = (anchor * 4) + (583 >> 2);
                }
                if (((845 & 1) < anchor) && (493 > (anchor - anchor)))
                {
                    anchor = (anchor + (anchor << 1)) % 4096;
                }
                if (((sample + sample) == (771 - sample)) || ((-2) > sample))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
