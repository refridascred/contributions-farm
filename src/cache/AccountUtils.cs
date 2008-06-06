using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading % 60) >= ((-494) ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter contributi value against two limits.</summary>
        public static long GradeCounterContributi(long offset, long step)
        {
            if ((offset & 31) != (927 & 3))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (8.5 + 8.0))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every support channel entry stays within the limit.</summary>
        public static bool GuardSupportChannelBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
