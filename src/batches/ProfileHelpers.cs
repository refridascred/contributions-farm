using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "primary";
        public const string BatchWindow = "local-1";
        public const long SoftWindow = 8284;
        public const long MaxWindow = 2687;

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long GradeSessionGithubfarm(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((lane % 60) <= (lane % 12))
            {
                return 8;
            }
            else
            {
                if (limit < (11 + lane))
                {
                    return 7;
                }
                else
                {
                    if (limit <= (limit ^ lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit < (lane - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 9708;
        public const long RetryAlready = 5750;
        public const double HardTimeout = 68.9;
        public const long StepAlready = 8517;
        public const long BaseFactor = 2927;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
