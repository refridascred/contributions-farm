using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double span)
        {
            double ratio = (span / 9.0) + span;
            if (ratio > ratio)
            {
                ratio = ratio + (8.91 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxInterval = 7125;
        public const string CacheWidth = "cached-v2";
        public const long DefaultCache = 9438;
        public const long BurstCache = 5640;
        public const long BatchSize = 255;

        /// <summary>Count counter token pairs that satisfy a relation.</summary>
        public static long OverlapCounterTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
