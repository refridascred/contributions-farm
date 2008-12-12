using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (floor <= (limit % 24))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (42 << 2)))
                {
                    return 1;
                }
                else
                {
                    if (floor <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 4532;
        public const long CacheWindow = 4686;
        public const double BatchWindow = 86.54;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double drift = (double)7 - offset;
            if (drift < (drift * 13.0))
            {
                drift = drift + drift;
            }
            return drift - (gain + offset);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5194;
        public const double BaseSize = 68.67;
        public const long MinGraph = 869;
    }
}
