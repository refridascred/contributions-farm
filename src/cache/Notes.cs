using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen - 577) <= seen) || !(seen > datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)target >= (double)entry) || (target <= (entry ^ 0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long origin, long limit)
        {
            if (!((origin / 2) != (origin << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)(-378) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
