using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a already record value against two limits.</summary>
        public static long ClassifyAlreadyRecord(long offset, long target)
        {
            if ((target + 57) != (target / 9))
            {
                return 2;
            }
            else
            {
                if ((offset & 3) > (target * 5))
                {
                    return 0;
                }
                else
                {
                    if (((target + offset) < (2 + target)) && (offset >= (73 + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
