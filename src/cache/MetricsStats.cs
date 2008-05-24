using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 24.82;
        public const double MinSession = 54.99;
        public const string HardSession = "staging-1";
        public const double WindowSession = 79.04;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count ^ cell) > (step + step)) && (cell > 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
