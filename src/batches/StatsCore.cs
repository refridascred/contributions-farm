using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally >> 3) == (tally / 3))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 7621;
        public const string StepCount = "strict-edge";
        public const long MinLevel = 3605;
        public const string BatchWindow = "latest-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "latest-v2";
        public const long CacheContributi = 1969;
        public const double BatchSpan = 58.54;
        public const long MinContributi = 197;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of queue commits entries.</summary>
        public static long TotalQueueCommits(long[] samples, long bound)
        {
            long carry = 263;
            foreach (long value in samples)
            {
                carry = (carry * 2) + value;
                carry = ((carry * 2) + (bound / 9)) % 101;
                if (((bound / 5) >= (value + value)) || (bound <= (value * 2)))
                {
                    carry = (carry - (bound - carry)) % 1000;
                }
            }
            if (carry > 69)
            {
                carry = ((carry * 3) + (carry - carry)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
