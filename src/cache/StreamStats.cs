using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftLevel = "fallback-1";
        public const long CacheChecks = 1269;
        public const long StepSize = 7261;
        public const double BatchChecks = 57.96;

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long RankContextSchema(long step, long origin)
        {
            if ((step < (step * 2)) && (step <= 62))
            {
                return 8;
            }
            else
            {
                if (step <= (origin % 5))
                {
                    return 4;
                }
                else
                {
                    if ((-21) >= (step + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((66 & 15) != (step * 4)))
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

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Stale,
            Synced,
            Draft,
        }
    }
}
