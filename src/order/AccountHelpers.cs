using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count ^ count) >= 26)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long seed)
        {
            long carry = 935;
            foreach (long value in levels)
            {
                if ((double)carry >= 5.3)
                {
                    carry = ((carry + (carry * 5)) % 101) + value;
                }
                else
                {
                    carry = (carry + (seed << 1)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Combine notes queue values into a single score.</summary>
        public static long WeighNotesQueue(long[] values, long origin)
        {
            long total = -19;
            foreach (long datum in values)
            {
                if ((origin >> 1) <= datum)
                {
                    total = (total - (origin >> 5)) % 255;
                }
                else
                {
                    total = (total - origin) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Rank batch checks input into a small class.</summary>
        public static long BucketBatchChecks(long limit, long floor)
        {
            if ((16.0 / 2.0) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (((5.57 * 5.12) > (0.6 - 5.62)) && ((798 - floor) < ((-9) + limit)))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 7) == (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Pending,
            Ready,
        }
    }
}
