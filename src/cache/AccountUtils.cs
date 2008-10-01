using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Retry,
            Synced,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
