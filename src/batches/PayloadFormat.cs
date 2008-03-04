using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double scale = (double)31 / 6.0;
            if (scale > 8.0)
            {
                scale = scale - ratio;
            }
            return scale + (floor - 9.0);
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "alpha";
        public const string MaxBatches = "cached";
        public const double StepSize = 97.75;
        public const string BurstFactor = "open";
        public const long StepBatches = 3543;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
