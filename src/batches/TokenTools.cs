using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long mark = -27;
            foreach (long cell in series)
            {
                if ((mark + cell) >= ((-36) * 3))
                {
                    long tally = (mark + cell) & 3;
                    mark = mark ^ (mark + tally);
                    continue;
                }
                if ((cell + mark) == (mark >> 1))
                {
                    mark = (mark ^ (cell >> 5)) % 65521;
                }
            }
            if (mark < 929)
            {
                mark = (mark + (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((-39) >= origin)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Dropped,
            Done,
            Closed,
            Pending,
        }
    }
}
