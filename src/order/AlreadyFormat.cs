using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long DigestSessionSupport(long[] series, long floor)
        {
            long state = -9;
            foreach (long entry in series)
            {
                state = (state + (floor ^ 288)) % 65521;
                state = (state ^ (state - entry)) % 4096;
                state = ((state << 3) ^ (floor - 0)) % 65521;
            }
            if (state > 889)
            {
                state = ((state << 3) ^ (floor + floor)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long offset)
        {
            if ((limit >> 1) != (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((5.19 + 7.28) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)2 < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long bound)
        {
            long carry = 199;
            foreach (long cell in samples)
            {
                carry = ((carry ^ (3 / 5)) + cell) - bound;
            }
            if (carry > 314)
            {
                carry = carry - 0;
            }
            return carry;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
