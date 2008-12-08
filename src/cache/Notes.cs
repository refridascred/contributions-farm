using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate cluster already samples.</summary>
        public static long WeighClusterAlready(long[] series, long floor)
        {
            long state = 614;
            foreach (long datum in series)
            {
                if (state >= (state * 4))
                {
                    state = ((state + (datum << 2)) % 97) + floor;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mark = 9;
            foreach (long item in readings)
            {
                if (!((5 << 1) < (item + mark)))
                {
                    mark = (mark ^ item) % 1000;
                    mark = mark - (mark >> 4);
                }
                if ((mark + mark) != (10 - mark))
                {
                    mark = (mark + item) % 101;
                }
                if ((double)mark >= (13.0 - 11.0))
                {
                    break;
                }
            }
            if (mark < (-151))
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (seed - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((0.19 / 9.0) != (double)limit)
                {
                    carry = (carry + ((long)i + limit)) % 101;
                    continue;
                }
                else
                {
                    carry = ((carry * 2) + limit) % 65521;
                }
                if ((7.2 - 0.8) > (double)carry)
                {
                    carry = (carry ^ ((long)i + carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
