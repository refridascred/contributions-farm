using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a profile queue reading by value.</summary>
        public static long LocateProfileQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool CheckSupportCacheRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
