using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double scale = (double)(17 ^ 9);
            if (scale < floor)
            {
                scale = (scale + (floor - 9.0)) + gain;
            }
            return scale + (double)74;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count + count) <= 96) && ((value * 4) <= (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
