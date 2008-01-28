using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double bias = offset;
            return bias - (ratio - 6.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheFactor = 2908;
        public const long MinChecks = 9918;
        public const long MaxChecks = 9487;
        public const long BatchChecks = 6364;
        public const long BaseRatio = 6636;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings)
        {
            long carry = 79;
            foreach (long item in readings)
            {
                carry = carry ^ (item & 7);
            }
            return carry;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long state = 138;
            foreach (long item in items)
            {
                if ((target / 3) > (target % 16))
                {
                    state = ((state << 3) ^ (target * 2)) ^ item;
                }
                else
                {
                    state = (state * 2) + target;
                }
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                if (((anchor + cell) != (anchor >> 5)) && ((cell ^ anchor) > (anchor ^ anchor)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
