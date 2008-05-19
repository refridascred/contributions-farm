using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) <= entry)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            New,
            Draft,
            Locked,
            Done,
        }
    }
}
