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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((6 + entry) <= target) && ((3.38 * 9.54) == (double)target))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
