using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
