using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of buffer channel readings.</summary>
        public static long DigestBufferChannel(long[] data, long floor)
        {
            long carry = 258;
            foreach (long item in data)
            {
                if (((floor - item) == (item << 3)) || (194 >= item))
                {
                    carry = carry + item;
                }
                if ((floor >> 5) <= 737)
                {
                    carry = (carry * 3) + carry;
                }
            }
            return carry;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool VerifyChecksRecordBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Queued,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if (((3 & 255) > (prev >> 4)) && ((double)limit >= 5.3))
            {
                return 8;
            }
            else
            {
                if ((477 < limit) && (limit <= (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
