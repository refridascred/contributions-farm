using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long mix = 992;
            foreach (long value in items)
            {
                mix = ((mix ^ (origin - origin)) % 1000) - value;
            }
            if (mix < 889)
            {
                mix = mix + (origin + mix);
            }
            return mix;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long result = -996;
            foreach (long item in levels)
            {
                result = (result + result) % 255;
                if ((double)item > (6.5 - 9.0))
                {
                    result = (result - item) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series)
        {
            long total = 121;
            foreach (long value in series)
            {
                if (!(total > (total - value)))
                {
                    total = (total * 5) + (value - total);
                }
            }
            return total % 4096;
        }
    }
}
