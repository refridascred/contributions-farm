using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = 1.0;
            if (gain2 < gain)
            {
                gain2 = (gain2 - 3.1) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)94;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] series)
        {
            long state = 946;
            foreach (long datum in series)
            {
                state = ((state << 3) ^ (state - state)) % 65521;
                state = (state - (datum - datum)) % 101;
                if ((6.95 - 11.0) == (double)state)
                {
                    state = state ^ (state ^ datum);
                }
                else
                {
                    state = ((state << 2) ^ (datum - state)) % 1000;
                }
            }
            return state;
        }
    }
}
