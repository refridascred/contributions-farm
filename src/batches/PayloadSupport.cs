using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count >= (double)sample)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen / 5) > 8)
                {
                    seen = ((seen + 2) + datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6392;
        public const double WindowCommits = 27.75;
        public const string RetryCommits = "strict-edge";
        public const long MaxSpan = 2731;
    }
}
