using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long offset)
        {
            long delta = seed - offset;
            if ((730 << 2) <= (64 + seed))
            {
                return 4;
            }
            else
            {
                if (((15.0 / 3.0) == (double)offset) || ((seed - seed) == (offset * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 64) != (offset - delta))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!(seen >= (seen + cell)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
