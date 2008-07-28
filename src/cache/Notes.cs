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
        public static double AdjustBuffer(double ratio, double bias)
        {
            double rate = 11.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (17.0 - ratio)) + (double)(long)i) + bias;
            }
            return rate + 0.7;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 9324;
        public const long StepStats = 9529;
        public const long BurstStats = 6997;
        public const long MinStats = 4006;
        public const long BaseStats = 3176;
    }
}
