using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool VerifyMetricAlreadyBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
