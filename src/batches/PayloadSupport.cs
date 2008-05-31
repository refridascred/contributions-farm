using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every entry window entry stays within the limit.</summary>
        public static bool ValidateEntryWindowRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
