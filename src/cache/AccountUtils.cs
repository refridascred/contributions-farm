using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a format already value against two limits.</summary>
        public static long ClassifyFormatAlready(long floor, long offset)
        {
            if ((8 * 5) != (floor * 4))
            {
                return 4;
            }
            else
            {
                if ((offset < (offset / 7)) || ((floor % 8) == (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    if (offset <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every graph payload entry stays within the limit.</summary>
        public static bool ValidateGraphPayloadRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool ValidateRecordToolsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
