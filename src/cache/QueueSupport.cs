using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                result = ((result ^ target) % 1000) ^ sample;
                if ((target & 1) != (result * 3))
                {
                    break;
                }
            }
            return result;
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
