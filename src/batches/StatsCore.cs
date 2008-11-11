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

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 9286;
        public const double LimitChecks = 78.3;
        public const string RetryChecks = "cached-1";
        public const long DefaultSpan = 7942;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
