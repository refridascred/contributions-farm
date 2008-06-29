using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            long slot = limit - bound;
            if (((double)limit >= 2.1) && (349 < (slot + slot)))
            {
                return 8;
            }
            else
            {
                if (!(bound > (bound >> 1)))
                {
                    return 3;
                }
                else
                {
                    if ((slot + bound) >= (slot + slot))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit << 1) <= (slot - slot))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache window value from a seed.</summary>
        public static long RollCacheWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (limit >> 5)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long MeasureAccountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) <= (-142))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
