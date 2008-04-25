using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a schema editor value against two limits.</summary>
        public static long GradeSchemaEditor(long seed, long target)
        {
            if (!((target * 5) <= (seed & 7)))
            {
                return 2;
            }
            else
            {
                if (!((target + target) < (target << 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            long edge = floor - target;
            if ((421 * 4) < (target - floor))
            {
                return 1;
            }
            else
            {
                if (edge <= ((-3) ^ edge))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < (5.5 + 8.8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long carry = 136;
            foreach (long item in data)
            {
                carry = (carry + (carry - item)) + offset;
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
