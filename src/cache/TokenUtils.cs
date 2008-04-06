using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (seen + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data)
        {
            long mix = -2;
            foreach (long item in data)
            {
                mix = mix + item;
                if ((mix + item) < (6 + 319))
                {
                    mix = (mix << 2) ^ item;
                }
                else
                {
                    mix = (mix * 2) + mix;
                }
            }
            return mix;
        }

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long TallyMetricsFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 255) >= (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
