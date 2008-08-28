using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format command entries.</summary>
        public static long FoldFormatCommand(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix << 1)) + value;
            }
            if (mix > 70)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool ValidateBatchesChecksLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long offset, long seed)
        {
            if (!((offset % 24) < (offset + offset)))
            {
                return 7;
            }
            else
            {
                if ((double)seed < (6.97 + 6.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
