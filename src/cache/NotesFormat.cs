using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit editor record readings against a rule.</summary>
        public static long CountEditorRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (8.73 > (double)count)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long step = origin ^ seed;
            if (((-78) + seed) >= (step / 7))
            {
                return 3;
            }
            else
            {
                if ((origin >> 3) == (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 7) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((882 * 5) < (113 - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Locked,
            Retry,
            Active,
            Closed,
        }
    }
}
