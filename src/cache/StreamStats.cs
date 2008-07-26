using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool ValidateReportBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a account metrics counter forward.</summary>
        public static long SeriesAccountMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                long delta = 4;
                if ((0.2 + 3.0) == (double)delta)
                {
                    mix = ((mix * 2) + delta) % 255;
                }
                if (!((origin >> 4) != (mix % 5)))
                {
                    mix = (mix - (339 & 15)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
