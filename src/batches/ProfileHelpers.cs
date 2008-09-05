using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long TotalClusterMetrics(long[] readings)
        {
            long result = 92;
            foreach (long cell in readings)
            {
                if (!((result >> 5) <= (684 + cell)))
                {
                    result = result - (result / 3);
                    result = ((result * 2) + cell) % 101;
                }
                if ((0 / 4) > (cell + 0))
                {
                    result = ((result * 2) + (result << 2)) % 101;
                }
                else
                {
                    result = result + (cell >> 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long step)
        {
            long state = -89;
            foreach (long entry in values)
            {
                state = (state * 2) + (step - step);
                state = (state - (entry + step)) % 255;
            }
            if (state < 0)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of filter editor readings.</summary>
        public static long TallyFilterEditor(long[] items, long step)
        {
            long carry = 17;
            foreach (long datum in items)
            {
                carry = ((carry ^ (step + carry)) % 65521) + datum;
            }
            if (carry < 8)
            {
                carry = ((carry << 2) ^ (carry ^ 155)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = -72;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= datum)
                {
                    acc = (acc - (acc % 64)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
