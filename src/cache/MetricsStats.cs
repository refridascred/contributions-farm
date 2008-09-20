using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFactor = 56.24;
        public const long StepInterval = 7119;
        public const double SoftFarm = 26.71;
        public const long WindowFarm = 8963;
        public const string DefaultTimeout = "strict-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftRatio = 65.71;
        public const long BatchProfile = 4939;
        public const long SoftProfile = 1655;
        public const string BatchBudget = "fallback-v2";

        /// <summary>Fold a list of githubfarm route readings.</summary>
        public static long ScoreGithubfarmRoute(long[] levels)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                long seen = (reading + sum) / 9;
                if (((reading - reading) <= sum) || ((sum >> 5) < (sum + sum)))
                {
                    seen = (seen - (seen >> 1)) % 4096;
                    sum = ((sum * 4) + (seen + reading)) % 97;
                }
                sum = ((sum * 4) + sum) % 255;
            }
            if (sum > (-1))
            {
                sum = (sum << 2) ^ (662 * 2);
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
