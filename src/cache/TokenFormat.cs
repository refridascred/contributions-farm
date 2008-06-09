using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long TallyChecksContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item << 2) < (item + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((6.25 / 4.0) != (double)datum)
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm cluster entry stays within the limit.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
