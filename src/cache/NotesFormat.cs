using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item % 60) <= (229 + count)) && ((double)244 > (double)item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long origin)
        {
            long span = step ^ origin;
            if ((67 + origin) >= (56 & 255))
            {
                return 8;
            }
            else
            {
                if ((6 * 3) >= (807 + span))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > (2.35 / 6.0)) && (span >= origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step >= (8.2 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry context values into a single score.</summary>
        public static long ScoreEntryContext(long[] items)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = (total << 3) ^ cell;
            }
            if (total > 285)
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
