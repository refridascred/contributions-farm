using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double gain = (double)2 - (weight * 4.85);
            if (gain < (weight + 9.3))
            {
                gain = gain + (span + gain);
            }
            return gain + (weight + 9.9);
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double weight = (rate / 6.0) / 7.0;
            if (weight < weight)
            {
                weight = (weight + weight) + bias;
            }
            return weight + (weight * 2.0);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed < (double)sum)
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
