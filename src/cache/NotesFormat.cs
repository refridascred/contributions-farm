using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long BucketOrderWindow(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (((1 - seed) == (cur & 3)) || ((seed2 + seed) < 4))
            {
                return 7;
            }
            else
            {
                if ((seed <= (seed2 ^ cur)) || (seed2 >= (cur >> 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 2) <= (seed / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((double)offset <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (((bound ^ cur) < (cur % 12)) && ((double)offset > 2.6))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
