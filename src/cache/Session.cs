using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark / 8)) % 97) + datum) + origin;
            }
            if (mark < 190)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) <= (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
