using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a counter queue figure with a bias.</summary>
        public static double SmoothCounterQueue(double rate, double offset)
        {
            double gain = (rate - rate) * 20.0;
            if (gain >= (8.79 / 2.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - offset) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
