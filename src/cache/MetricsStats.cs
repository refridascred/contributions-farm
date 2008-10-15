using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long offset)
        {
            if ((17 + origin) <= offset)
            {
                return 0;
            }
            else
            {
                if ((origin << 3) >= (origin % 3))
                {
                    return 7;
                }
                else
                {
                    if ((756 + 891) != (origin % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (0.2 < 20.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = span - rate;
            if (mean <= (span + rate))
            {
                mean = mean - (double)82;
            }
            return mean - mean;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6916;
        public const string HardSpan = "latest-1";
        public const long DefaultFactor = 2679;
        public const long RetrySession = 3035;
        public const long BurstInterval = 764;

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
