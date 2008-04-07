using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 3443;
        public const string WindowInterval = "strict-1";
        public const long WindowFactor = 1116;
    }
}
