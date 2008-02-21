using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long target)
        {
            if (((target << 2) != (target + seed)) || (target > (763 << 2)))
            {
                return 1;
            }
            else
            {
                if (475 < (seed ^ seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed != (5.8 + 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed * 4) >= (seed - 812))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Count the report cluster entries that pass the check.</summary>
        public static long MeasureReportClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits > 50)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 97.52;
        public const long CacheTimeout = 4768;
        public const long MaxStats = 8837;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
