using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long target2)
        {
            long offset = target - target2;
            if ((offset - target2) < (6 - offset))
            {
                return 5;
            }
            else
            {
                if (((target + offset) >= (offset / 3)) && ((92 - offset) != (offset * 2)))
                {
                    return 7;
                }
                else
                {
                    if ((374 & 127) == (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
