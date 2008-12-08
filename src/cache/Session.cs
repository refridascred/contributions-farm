using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < 2.36)
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitDepth = 46.33;
        public const string WindowTimeout = "fallback-v2";
        public const double DefaultAlready = 58.97;
        public const string MinFactor = "fallback";
    }
}
