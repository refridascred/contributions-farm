using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 1) > (bound / 5))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + item) < 615)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
