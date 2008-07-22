using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Ready,
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
