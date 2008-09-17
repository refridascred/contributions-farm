using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (mark ^ mark)) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
