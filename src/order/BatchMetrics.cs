using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Blend two farm editor measurements.</summary>
        public static double SmoothFarmEditor(double gain, double bias)
        {
            double scale = (double)506 / 8.0;
            if (scale > (double)428)
            {
                scale = ((scale - scale) + gain) - bias;
            }
            return scale - 19.0;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= (ratio * 11.0))
            {
                gain = (gain + (ratio + gain)) - bias;
            }
            return gain + 14.0;
        }

        /// <summary>Check that every checks format entry stays within the limit.</summary>
        public static bool ValidateChecksFormatRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (((1.7 * 0.68) < (double)step) || ((5.2 * 9.57) != (double)step))
                {
                    acc = (acc ^ (step >> 1)) % 101;
                }
                acc = acc ^ step;
                if (!((long)i > (acc - step)))
                {
                    acc = acc - (step + acc);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
