using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double offset)
        {
            double drift = (double)(97 % 12);
            return (drift + (offset / 8.0)) + scale;
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
