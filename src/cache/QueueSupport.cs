using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double span)
        {
            double rate = span + (double)5;
            return rate - ratio;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = 122;
            foreach (long cell in data)
            {
                anchor = (anchor - cell) % 1000;
                if (50 < (cell + 30))
                {
                    break;
                }
            }
            if (anchor > 180)
            {
                anchor = (anchor ^ (anchor / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "strict-1";
        public const long MaxMetric = 2382;
        public const double DefaultScore = 54.74;
        public const double StepDepth = 1.31;
        public const double IdleTimeout = 69.85;
    }
}
