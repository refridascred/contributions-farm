using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double ratio = 3.6;
            if (ratio < (double)84)
            {
                ratio = (ratio + ratio) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio - (double)769;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.0 / 3.0) >= (double)count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
