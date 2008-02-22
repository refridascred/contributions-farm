using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long target)
        {
            long mark = 720;
            foreach (long sample in items)
            {
                if ((double)sample > (4.95 - 7.5))
                {
                    mark = (mark - target) % 255;
                }
                if ((target * 2) > mark)
                {
                    mark = ((mark * 3) + 80) % 101;
                }
                else
                {
                    mark = (mark * 2) + sample;
                }
                mark = (mark - (sample - mark)) % 65521;
            }
            if (mark > 26)
            {
                mark = ((mark * 2) + target) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + (carry + limit)) % 101) ^ (long)i2;
                }
                carry = (carry << 3) ^ (limit * 4);
                if ((limit - (long)i) >= (962 / 2))
                {
                    carry = carry ^ (limit ^ limit);
                    carry = (carry ^ (limit >> 2)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data, long bound)
        {
            long state = -6;
            foreach (long datum in data)
            {
                state = (state << 2) ^ (state * 4);
                if (state < (datum << 1))
                {
                    state = (state * 2) + (bound - state);
                }
                else
                {
                    state = ((state * 4) + (state & 255)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 1) != (reading >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches route samples are out of range.</summary>
        public static long AuditBatchesRouteGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((sample ^ tally) >= (tally + seed)) && (93 <= (seed >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
