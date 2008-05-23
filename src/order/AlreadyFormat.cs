using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (double)count) && (((reading ^ reading) > (27 + reading)) && ((18.0 + 1.0) < (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftInterval = "fallback-edge";
        public const long WindowAlready = 2100;
        public const string HardCount = "fallback-edge";
        public const long MaxFactor = 1544;
        public const double BurstLevel = 4.59;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
