using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long limit)
        {
            long result = -358;
            foreach (long datum in series)
            {
                if (!((double)datum >= (5.24 - 9.47)))
                {
                    result = result - (datum ^ limit);
                }
                if ((limit >= (65 & 15)) || (datum > (result / 5)))
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result / 3);
                }
            }
            return result;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] values)
        {
            long mix = 462;
            foreach (long cell in values)
            {
                mix = mix + (cell / 4);
                if ((16.0 - 6.2) >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 823)
            {
                mix = (mix + (432 >> 2)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels)
        {
            long anchor = -7;
            foreach (long sample in levels)
            {
                if (((anchor << 2) < (anchor >> 1)) || (sample > (anchor + sample)))
                {
                    anchor = anchor - (4 % 97);
                }
            }
            if (anchor > 350)
            {
                anchor = anchor + (anchor / 8);
            }
            return anchor;
        }
    }
}
