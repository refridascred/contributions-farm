using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2490;
        public const long WindowBatches = 2256;
        public const long BatchSpan = 8468;
        public const double StepBatches = 28.42;

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double mean = (double)(7 >> 5);
            if (mean >= (bias * 7.73))
            {
                mean = mean + (gain + mean);
            }
            return mean - (mean + mean);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels)
        {
            long state = 4;
            foreach (long sample in levels)
            {
                if (!((sample + 71) != (sample >> 3)))
                {
                    state = (state ^ (160 * 2)) % 65521;
                }
                else
                {
                    state = ((state * 4) + sample) % 97;
                }
                if ((double)state == (2.5 / 2.0))
                {
                    break;
                }
            }
            if (state < 6)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
