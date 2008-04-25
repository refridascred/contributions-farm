using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long bound)
        {
            long slot = limit ^ bound;
            if (!((limit << 3) < (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) > (slot * 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 7) > (slot * 5)) && ((double)slot == (10.0 + 6.8)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "fallback-edge";
        public const long RetryGithubfarm = 6957;
        public const double LimitDepth = 93.49;
        public const long HardGithubfarm = 3092;
        public const long DefaultFactor = 6077;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9198;
        public const long HardChecks = 3984;
        public const long BaseDepth = 2605;
        public const long BatchLevel = 4802;
        public const double StepSize = 77.49;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
