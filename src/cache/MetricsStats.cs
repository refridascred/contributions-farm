using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine route stream values into a single score.</summary>
        public static long WeighRouteStream(long[] samples, long bound)
        {
            long result = 4;
            foreach (long item in samples)
            {
                if ((item % 97) <= (result ^ 315))
                {
                    result = (result + ((long)samples.Length * 5)) % 255;
                }
                result = result + (206 + (-35));
            }
            if (result > 604)
            {
                result = (result - (bound + 113)) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 9712;
        public const long CacheBudget = 2743;
        public const long RetrySize = 9771;
        public const string BurstSize = "cached-edge";

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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
