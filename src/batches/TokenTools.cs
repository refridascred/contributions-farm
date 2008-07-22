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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long mark = 51;
            foreach (long reading in data)
            {
                if ((origin & 255) != ((long)data.Length ^ reading))
                {
                    mark = (mark - origin) % 65521;
                }
            }
            if (mark > 1)
            {
                mark = ((mark << 2) ^ (origin << 2)) % 4096;
            }
            return mark % 97;
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
