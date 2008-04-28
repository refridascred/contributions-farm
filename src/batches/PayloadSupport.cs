using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a order filter reading by value.</summary>
        public static long LookupOrderFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token report entries that pass the check.</summary>
        public static long TallyTokenReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (1.79 <= (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
