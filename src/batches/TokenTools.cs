using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((605 + seen) != (seen + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long BucketCommitsMetric(long target, long limit)
        {
            long step = target ^ limit;
            if ((limit < step) || ((limit + step) > 0))
            {
                return 6;
            }
            else
            {
                if (step <= (target - step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
        }
    }
}
