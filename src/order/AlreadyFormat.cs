using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - floor) == ((-8) - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor cluster pair into a bucket.</summary>
        public static long SortEditorCluster(long bound, long offset)
        {
            long span = bound - offset;
            if ((span + bound) == (421 & 3))
            {
                return 2;
            }
            else
            {
                if ((312 + bound) != (205 & 31))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= 0.37)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples)
        {
            long total = 83;
            foreach (long value in samples)
            {
                total = (total + (total + total)) ^ value;
            }
            return total % 4096;
        }
    }
}
