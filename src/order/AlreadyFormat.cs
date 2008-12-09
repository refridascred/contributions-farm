using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long target, long seed)
        {
            long next = target + seed;
            if (93 <= (seed + next))
            {
                return 7;
            }
            else
            {
                if ((target + 325) >= next)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 / 9.0) < (17.0 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((332 & 7) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long TallyNotesWindow(long[] items)
        {
            long carry = 58;
            foreach (long item in items)
            {
                if (!((item & 255) == (item / 2)))
                {
                    carry = (carry - (carry - (-617))) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (carry * 5);
                }
                if ((2 / 7) >= (item << 2))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = ((carry ^ 934) + item) + seed;
                carry = (carry - 83) % 101;
            }
            return carry % 97;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
