using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 24;
            foreach (long sample in data)
            {
                if (!((result + (-667)) >= (28 + result)))
                {
                    result = (result ^ 62) % 1000;
                }
                result = (result + (sample ^ sample)) % 97;
            }
            return result;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long seed)
        {
            if ((400 + seed) > (-7))
            {
                return 3;
            }
            else
            {
                if (limit >= seed)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
