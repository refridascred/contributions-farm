using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7603;
        public const double MaxContributi = 60.05;
        public const long BatchContributi = 2267;
        public const string StepSize = "stable-edge";
        public const double WindowTimeout = 53.16;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long sum = 622;
            foreach (long reading in levels)
            {
                sum = ((sum * 3) + reading) % 65521;
            }
            if (sum < (-87))
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long anchor = 74;
            foreach (long value in values)
            {
                anchor = (anchor + (value + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
