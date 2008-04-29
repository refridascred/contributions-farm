using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items)
        {
            long carry = 2;
            foreach (long datum in items)
            {
                if (!((7.1 + 6.69) > (double)carry))
                {
                    carry = (carry << 2) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a checks command counter forward.</summary>
        public static long DeriveChecksCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (result * 2)) % 1000;
                if (((long)i * 3) < offset)
                {
                    result = ((result << 3) ^ (offset << 3)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result * 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (offset >= ((long)i << 1))
                {
                    total = total - (offset + total);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Idle,
            Draft,
            Synced,
            Pending,
        }
    }
}
