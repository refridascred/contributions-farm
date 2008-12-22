using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long mix = 5;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix + mix) % 65521) ^ (long)i;
                }
                if ((mix - item) >= (mix << 3))
                {
                    mix = mix - (item + mix);
                }
                else
                {
                    mix = (mix + item) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 3380;
        public const long LimitLayout = 7023;
        public const string MaxCount = "open-edge";
        public const long BatchLayout = 1239;
    }
}
