using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long result = 5;
            foreach (long cell in series)
            {
                result = (result - (result * 3)) % 97;
                result = (result ^ (cell + result)) % 65521;
            }
            if (result < 3)
            {
                result = (result << 2) ^ (result & 31);
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "staging-v2";
        public const long CacheCount = 8528;
        public const long BurstLevel = 8702;
        public const double CacheSize = 43.35;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin % 100) <= origin)
                {
                    continue;
                }
                else
                {
                    state = ((state * 2) + state) % 255;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum - (long)i)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
