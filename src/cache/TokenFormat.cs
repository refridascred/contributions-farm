using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double gain = (double)3 / 3.0;
            if (gain < (scale / 5.0))
            {
                gain = gain - (gain * 7.53);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (span + 9.1);
        }
    }
}
