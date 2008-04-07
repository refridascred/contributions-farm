using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command record readings against a rule.</summary>
        public static long CountCommandRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)15)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Active,
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix ^ (40 >> 2)) ^ value;
            }
            if (mix > 2)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool ValidateAlreadyFilterLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits % 10) > (seed ^ entry))
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
    }
}
