using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a report channel value against two limits.</summary>
        public static long ClassifyReportChannel(long offset, long bound)
        {
            if ((bound <= (offset + 8)) && ((offset / 5) < bound))
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) > 22)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((73 << 3) >= (origin + origin)) || ((seen * 4) > (origin ^ seen)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((step + step) != (step - step))
            {
                return 1;
            }
            else
            {
                if ((double)(-819) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((710 ^ step) > 8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
