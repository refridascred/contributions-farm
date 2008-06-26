using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long limit, long floor)
        {
            if (((10.0 / 3.0) <= (double)floor) || ((floor - floor) < (floor / 6)))
            {
                return 2;
            }
            else
            {
                if (floor >= (limit + 445))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const long RetrySession = 96;
        public const long StepTimeout = 5907;
    }
}
