using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Accumulate record stream samples.</summary>
        public static long TotalRecordStream(long[] levels, long limit)
        {
            long state = 533;
            foreach (long entry in levels)
            {
                if (limit <= (limit / 8))
                {
                    state = ((state * 2) + (659 << 3)) - entry;
                }
            }
            return state % 97;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
