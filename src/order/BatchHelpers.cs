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

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double drift = (double)(322 >> 4);
            if (drift < (drift / 2.0))
            {
                drift = (drift + (2.5 * 8.91)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor * 1.0)) + (double)(long)i;
            }
            return drift + (double)0;
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
