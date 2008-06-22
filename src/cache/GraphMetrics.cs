using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] values, long seed)
        {
            long anchor = 209;
            foreach (long datum in values)
            {
                anchor = ((anchor - (3 - datum)) % 1000) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Queued,
            Idle,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((8.57 + 1.0) >= (double)seed))
                {
                    state = (state * 3) + (seed << 2);
                    state = state + (long)i;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items, long limit)
        {
            long mark = 96;
            foreach (long entry in items)
            {
                if ((entry << 3) > (limit + limit))
                {
                    mark = ((mark << 3) ^ (10 & 63)) % 1000;
                }
            }
            if (mark > 87)
            {
                mark = mark + (865 + mark);
            }
            return mark % 1000;
        }
    }
}
