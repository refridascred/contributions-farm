using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long TotalSessionSupport(long[] samples, long offset)
        {
            long mix = 69;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 1000) - datum) - offset;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long CombineFarmBatch(long[] samples, long floor)
        {
            long total = 598;
            foreach (long item in samples)
            {
                total = ((total ^ floor) % 65521) - item;
                if ((double)total <= 1.3)
                {
                    total = ((total * 3) + (total >> 2)) % 255;
                }
                if (3.45 > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
