using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            New,
            Synced,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
