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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
