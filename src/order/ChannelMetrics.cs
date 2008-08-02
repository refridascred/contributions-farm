using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long total = -741;
            foreach (long value in series)
            {
                if ((double)value > (double)(long)series.Length)
                {
                    total = (total ^ (total & 7)) - floor;
                }
                if (total >= (total * 3))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long offset, long origin)
        {
            long cur = offset + origin;
            if (offset >= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((cur >> 1) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((1 & 127) > cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
