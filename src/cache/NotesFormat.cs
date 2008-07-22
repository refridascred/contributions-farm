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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
