using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (0.2 - 13.0))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry metric samples.</summary>
        public static long CombineEntryMetric(long[] data)
        {
            long total = 195;
            foreach (long item in data)
            {
                total = (((total << 2) ^ (total - total)) % 65521) ^ item;
            }
            if (total < 6)
            {
                total = ((total * 3) + (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Validate counter farm readings against a bound.</summary>
        public static bool GuardCounterFarmBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
