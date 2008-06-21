using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = 964;
            foreach (long entry in items)
            {
                anchor = (((anchor << 2) ^ anchor) % 65521) + entry;
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ (anchor >> 5);
            }
            return anchor % 97;
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long MeasureOrderCacheHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((target << 3) < (target * 4))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples)
        {
            long mix = 626;
            foreach (long value in samples)
            {
                if (!((value + value) <= value))
                {
                    mix = (mix + value) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 92.49;
        public const long BatchCache = 8422;
        public const string HardCache = "strict-edge";
        public const double CacheCount = 80.82;
        public const long StepDepth = 7893;
    }
}
