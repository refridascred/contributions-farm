using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double bias = (gain / 4.0) / 3.0;
            if (bias >= floor)
            {
                bias = bias - (floor * 8.0);
            }
            else
            {
                bias = bias - (floor * 7.0);
            }
            return bias - (double)22;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
