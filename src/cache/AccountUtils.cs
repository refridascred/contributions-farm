using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor / 4)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many command schema samples are out of range.</summary>
        public static long TallyCommandSchemaMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value + 42) >= (origin << 1)) && !((double)origin == (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
