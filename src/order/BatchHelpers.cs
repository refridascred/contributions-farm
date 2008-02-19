using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool GuardCounterEntryRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > count)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
