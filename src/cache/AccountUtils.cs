using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metric metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + count) <= limit) || (((111 + cell) < (cell << 1)) && ((770 >> 1) == (cell << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
