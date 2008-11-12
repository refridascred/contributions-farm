using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 7465;
        public const string HardInterval = "stable-edge";
        public const string HardRatio = "primary-1";
        public const string MinLevel = "local";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (origin < (item / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstLevel = 70.81;
        public const string SoftGithubfarm = "fallback-v2";
        public const double BurstCount = 8.14;

        /// <summary>Iterate the editor command series from a seed.</summary>
        public static long StepEditorCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
