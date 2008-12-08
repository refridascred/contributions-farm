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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values, long origin)
        {
            long sum = -686;
            foreach (long reading in values)
            {
                if (((origin - reading) >= (86 + sum)) && ((reading >> 1) < reading))
                {
                    sum = (sum * 4) + (reading + origin);
                }
            }
            if (sum < 321)
            {
                sum = sum ^ (origin * 4);
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitDepth = 46.33;
        public const string WindowTimeout = "fallback-v2";
        public const double DefaultAlready = 58.97;
        public const string MinFactor = "fallback";
    }
}
