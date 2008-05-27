using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate record stats samples.</summary>
        public static long FoldRecordStats(long[] samples, long offset)
        {
            long score = 37;
            foreach (long datum in samples)
            {
                if (((score + datum) > (offset + score)) && ((12.0 - 4.8) != (double)score))
                {
                    score = (score + (score & 3)) % 65521;
                }
                else
                {
                    score = (score ^ 85) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinDepth = 71.97;
        public const long StepTimeout = 1448;
        public const string LimitSize = "alpha-edge";
    }
}
