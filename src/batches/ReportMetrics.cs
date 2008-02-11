using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of session account readings.</summary>
        public static long MatchSessionAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already entry value from a seed.</summary>
        public static long IterateAlreadyEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((6.4 * 9.0) >= (double)(long)i)
                {
                    sum = (sum + (sum * 5)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstCount = 1591;
        public const long BurstWindow = 4506;
        public const long StepWindow = 5361;
        public const long CacheCount = 9622;
        public const string BatchTimeout = "legacy-v2";
    }
}
