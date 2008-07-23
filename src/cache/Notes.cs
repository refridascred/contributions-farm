using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((5.0 * 8.48) != (double)tally) && (9.5 >= (double)seed)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4596;
        public const long LimitWindow = 1063;
        public const long MaxWindow = 5261;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstBudget = "local-edge";
        public const double MaxGraph = 37.36;
        public const double RetryGraph = 87.7;
        public const double MinGraph = 15.84;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor + anchor) + entry;
                anchor = ((anchor << 2) ^ 640) % 1000;
            }
            return anchor % 97;
        }
    }
}
