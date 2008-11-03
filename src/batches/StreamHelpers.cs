using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long sum = 90;
            foreach (long datum in samples)
            {
                sum = ((sum * 2) + (bound - datum)) % 1000;
            }
            if (sum < 53)
            {
                sum = (sum - bound) % 255;
            }
            return sum;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6706;
        public const double RetryScore = 12.19;
        public const long BatchDepth = 4736;
        public const double WindowMetric = 0.41;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series, long bound)
        {
            long score = 38;
            foreach (long reading in series)
            {
                score = ((score ^ (score - reading)) % 4096) + bound;
            }
            if (score > 904)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Failed,
            Draft,
            Synced,
            Idle,
        }
    }
}
