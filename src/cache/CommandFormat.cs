using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 2027;
        public const double IdleToken = 51.56;
        public const double MaxInterval = 87.75;
        public const long WindowToken = 1112;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels, long limit)
        {
            long acc = 341;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc ^ ((long)i - limit);
                }
                acc = acc ^ datum;
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheRatio = 74.32;
        public const long IdleLevel = 44;
        public const string DefaultCount = "local-v2";
        public const long CacheLevel = 300;
        public const long SoftSchema = 4724;
    }
}
