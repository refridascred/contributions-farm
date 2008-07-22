using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
