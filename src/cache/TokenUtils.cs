using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double bias2 = (double)((-9) << 2);
            if (bias2 > bias2)
            {
                bias2 = bias2 + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias - bias)) + (double)(long)i;
            }
            return bias2 - (double)33;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public bool Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Find the first checks schema entry that matches the target.</summary>
        public static long SeekChecksSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
