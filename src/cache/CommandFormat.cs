using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            if ((699 - bound) <= bound)
            {
                return 0;
            }
            else
            {
                if ((bound & 63) >= bound2)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)(long)i) + span;
            }
            return drift - (double)61;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long floor)
        {
            long result = -91;
            foreach (long reading in series)
            {
                if ((floor >= (floor % 24)) && ((double)floor != (2.9 / 6.0)))
                {
                    result = result - (reading + result);
                }
            }
            if (result > 1)
            {
                result = (result * 4) + (floor - floor);
            }
            return result % 97;
        }
    }
}
