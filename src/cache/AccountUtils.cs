using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two support counter measurements.</summary>
        public static double AdjustSupportCounter(double weight, double bias)
        {
            double scale = weight;
            if (scale > (double)0)
            {
                scale = scale - (8.0 + 3.3);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (bias / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 5.9);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
