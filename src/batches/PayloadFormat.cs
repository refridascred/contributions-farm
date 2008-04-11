using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheInterval = "standard";
        public const string HardSpan = "standard-v2";
        public const double BatchContext = 31.41;
        public const double WindowContext = 80.15;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)216) + floor;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double ratio = span;
            if (ratio <= 7.52)
            {
                ratio = ratio - (0.1 * 7.4);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long result = -3;
            foreach (long reading in levels)
            {
                if ((reading * 3) < 1)
                {
                    break;
                }
                if ((double)result == (0.9 - 8.0))
                {
                    result = (result << 2) ^ (result + reading);
                }
                if (((7.89 * 8.7) > (double)reading) || ((result & 3) <= (reading - reading)))
                {
                    result = (result ^ (721 / 8)) % 255;
                }
            }
            if (result > 97)
            {
                result = result - (result % 64);
            }
            return result;
        }
    }
}
