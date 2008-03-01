using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleInterval = 71.07;
        public const string SoftRoute = "cached-edge";
        public const long DefaultRoute = 4749;
        public const double BatchCount = 21.09;
        public const double RetryBudget = 6.0;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + sample) == (limit + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (origin > (floor & 63))
            {
                return 8;
            }
            else
            {
                if (!((double)origin <= (7.44 + 1.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 4) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
