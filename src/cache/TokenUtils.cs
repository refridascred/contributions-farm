using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool GuardCounterStreamLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long acc = 9;
            foreach (long sample in data)
            {
                acc = acc + (acc >> 3);
                acc = ((acc * 2) + (sample & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long MeasureEntryProfileOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) <= (reading - step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
