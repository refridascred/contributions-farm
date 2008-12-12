using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 69.21;
        public const double MaxSupport = 13.12;
        public const long LimitSupport = 5534;
    }
}
