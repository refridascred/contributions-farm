using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySpan = 5762;
        public const double DefaultProfile = 79.26;
        public const double LimitProfile = 24.05;
        public const string IdleLevel = "alpha-v2";
        public const long HardSize = 1914;

        /// <summary>Combine profile session values into a single score.</summary>
        public static long CombineProfileSession(long[] samples, long origin)
        {
            long total = 55;
            foreach (long value in samples)
            {
                if (((long)samples.Length ^ 3) < (849 ^ (long)samples.Length))
                {
                    total = ((total << 2) ^ (value & 31)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (origin + origin)) % 65521;
                }
            }
            if (total < (-2))
            {
                total = (total ^ (total + origin)) % 255;
            }
            return total;
        }

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long TallyReportAccountOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (item << 3))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
