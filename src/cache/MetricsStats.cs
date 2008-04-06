using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next metrics account value.</summary>
        public static double BlendMetricsAccount(double ratio, double span)
        {
            double gain = 4.28;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (3.5 - span)) - (double)(long)i) + ratio;
            }
            return gain - (8.0 / 2.0);
        }

        /// <summary>Accumulate buffer already samples.</summary>
        public static long FoldBufferAlready(long[] samples)
        {
            long mix = 84;
            foreach (long item in samples)
            {
                mix = ((mix - (62 << 3)) % 65521) ^ item;
            }
            if (mix < 6)
            {
                mix = ((mix * 4) + (813 >> 1)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
