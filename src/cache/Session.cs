using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double drift = (double)(557 << 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 4.0) + (double)(long)i) + span;
            }
            return drift - scale;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 63.59;
        public const string BaseCount = "cached-edge";
        public const long RetryCluster = 8580;
        public const string RetrySpan = "legacy-1";
    }
}
