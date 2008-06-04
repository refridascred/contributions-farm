using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] values)
        {
            long total = 6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (total - (total << 3)) ^ (long)i;
                }
                total = (total - (sample * 5)) % 255;
                if ((sample + sample) < (sample & 15))
                {
                    total = (total - (long)values.Length) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 241;
        public const long MaxCache = 1132;
        public const string IdleCache = "latest-1";
        public const long MinBudget = 190;
        public const long StepCache = 2902;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long sum = 891;
            foreach (long item in readings)
            {
                if ((item - item) < sum)
                {
                    sum = ((sum * 4) + (item & 7)) % 1000;
                }
                if ((4.43 + 10.0) > (double)item)
                {
                    break;
                }
            }
            if (sum < 31)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double span)
        {
            double mean = (span - 9.5) / 8.0;
            if (mean <= span)
            {
                mean = mean + (16.0 * 9.0);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (6.9 / 7.0)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
