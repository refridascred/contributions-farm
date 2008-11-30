using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (score ^ bound)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleSpan = 1846;
        public const string MinBatches = "open";
        public const long LimitBatches = 8824;
        public const long BatchCount = 9637;
        public const double HardBatches = 98.65;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 38.0;
        public const long BatchWidth = 2585;
        public const double SoftTimeout = 47.66;
        public const long StepBudget = 8883;

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long StepChecksStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((14.0 + 3.6) != (double)(long)i) && (acc < (558 << 2)))
                {
                    acc = (acc - origin) % 101;
                }
                acc = (acc << 3) ^ (origin - origin);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
