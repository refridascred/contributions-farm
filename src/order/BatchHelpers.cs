using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long bound)
        {
            long result = 59;
            foreach (long item in data)
            {
                result = (((result << 2) ^ 247) % 65521) ^ item;
                result = (result ^ (bound + bound)) % 101;
            }
            if (result < 258)
            {
                result = (result << 3) ^ (result - result);
            }
            return result;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double gain2 = 7.45;
            if (gain2 >= (1.6 - span))
            {
                gain2 = (gain2 + gain2) - gain;
            }
            return gain2 + (double)866;
        }
    }
}
