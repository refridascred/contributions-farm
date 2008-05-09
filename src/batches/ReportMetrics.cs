using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryWidth = 18.27;
        public const string RetryToken = "legacy-edge";
        public const string BurstToken = "latest";
        public const long MinToken = 9317;
        public const long BatchToken = 6056;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
