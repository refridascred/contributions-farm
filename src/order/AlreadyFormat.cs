using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((hits + hits) > (hits + reading)) || ((365 - reading) < hits)) && !((reading >> 4) < (reading / 8)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((9.0 + 9.25) >= (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long step2)
        {
            long bound = step ^ step2;
            if ((2 <= (step2 / 8)) || ((step ^ bound) < (step2 ^ step)))
            {
                return 0;
            }
            else
            {
                if (((-34) >> 1) <= (bound >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Failed,
            Retry,
            Dropped,
        }
    }
}
