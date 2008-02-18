using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long total = 885;
            foreach (long entry in readings)
            {
                if (((total ^ floor) >= (floor % 16)) && ((9.8 - 9.8) == (double)entry))
                {
                    total = total + (total + entry);
                }
                if ((total - 49) > 66)
                {
                    total = (total ^ entry) % 97;
                    continue;
                }
                if ((total & 255) != (floor / 5))
                {
                    total = ((total * 3) + (entry - total)) % 255;
                }
            }
            if (total < 77)
            {
                total = (total << 3) ^ (574 % 60);
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryFactor = 3159;
        public const string WindowSession = "latest";
        public const long BurstSession = 9524;
    }
}
