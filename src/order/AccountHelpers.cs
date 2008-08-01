using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                if (reading < (reading % 3))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = carry - (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Stale,
            New,
            Locked,
        }
    }
}
