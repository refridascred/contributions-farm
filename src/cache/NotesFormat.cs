using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length - reading) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long target)
        {
            if ((0 - limit) < (target % 100))
            {
                return 6;
            }
            else
            {
                if (((96 - limit) <= limit) && ((9 + limit) >= (3 - target)))
                {
                    return 4;
                }
                else
                {
                    if ((target >= (limit / 2)) || ((target + target) == (945 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit - target) >= (limit & 15)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
