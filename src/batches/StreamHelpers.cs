using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 29;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor << 2)) ^ entry;
            }
            if (anchor > 440)
            {
                anchor = ((anchor * 2) + (anchor % 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Pending,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target >= hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if ((1.4 / 4.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if ((target / 6) > 8)
                {
                    return 4;
                }
                else
                {
                    if ((offset <= target) && (target <= (offset << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 4037;
        public const long StepMetrics = 9890;
        public const long CacheMetrics = 6575;
    }
}
