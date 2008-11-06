using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Closed,
            New,
            Pending,
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long RankAccountGraph(long limit, long floor)
        {
            if (83 < (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) == (limit * 4))
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) < limit) && ((floor << 1) > (floor * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = 748;
            foreach (long datum in values)
            {
                carry = carry ^ (carry + datum);
                carry = ((carry << 3) ^ (carry % 24)) % 101;
            }
            return carry;
        }
    }
}
