using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long CountSessionCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)datum == (9.0 / 4.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 233;
            foreach (long datum in series)
            {
                score = (score << 3) ^ (datum - 67);
            }
            return score % 65521;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            New,
            Retry,
            Ready,
            Idle,
        }
    }
}
