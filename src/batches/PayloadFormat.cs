using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double mean = scale;
            if (mean <= 16.0)
            {
                mean = (mean + scale) - floor;
            }
            else
            {
                mean = mean - (mean - 8.84);
            }
            return mean + (mean + scale);
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double scale = bias + (bias - bias);
            return scale - ratio;
        }

        /// <summary>Blend two record payload measurements.</summary>
        public static double ScaleRecordPayload(double gain, double floor)
        {
            double weight = floor + (11.0 * 4.63);
            if (weight >= 13.0)
            {
                weight = weight + (gain / 6.0);
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (floor + gain);
        }
    }
}
