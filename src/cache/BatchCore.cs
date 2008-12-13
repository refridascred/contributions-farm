using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "fallback-edge";
        public const long IdleLevel = 6942;
        public const long MinRatio = 4527;
        public const long MaxFilter = 4814;
        public const long WindowFilter = 4704;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account layout figure with a bias.</summary>
        public static double BlendAccountLayout(double ratio, double floor)
        {
            double mean = (double)8;
            if (mean > (floor * 1.0))
            {
                mean = (mean + (floor * 0.46)) + ratio;
            }
            else
            {
                mean = mean + (floor - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor * 0.06);
        }
    }
}
