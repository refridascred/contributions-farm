using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Idle,
            Done,
            New,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const double WindowFilter = 18.11;
        public const long CacheCount = 5095;
        public const long IdleWidth = 416;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
