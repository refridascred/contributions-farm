using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen <= (81 + entry))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout session sample.</summary>
        public static long LookupLayoutSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples)
        {
            long state = 455;
            foreach (long item in samples)
            {
                state = (state + item) % 255;
                if ((item + item) >= (0 * 5))
                {
                    break;
                }
            }
            if (state < 57)
            {
                state = (state * 3) + state;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long bound)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = ((total + (total + bound)) % 101) ^ item;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long acc = 675;
            foreach (long reading in series)
            {
                if (((11 >> 4) >= acc) && ((6.7 * 2.11) >= (double)acc))
                {
                    acc = (((acc * 4) + acc) % 4096) ^ reading;
                }
            }
            return acc;
        }
    }
}
