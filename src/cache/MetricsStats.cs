using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long result = -497;
            foreach (long cell in data)
            {
                result = (result - (cell - cell)) % 1000;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheRatio = "standard-v2";
        public const string WindowNotes = "primary-v2";
        public const double BatchFactor = 45.56;
        public const long RetryNotes = 5117;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
