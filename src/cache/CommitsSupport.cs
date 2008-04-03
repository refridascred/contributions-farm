using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 5468;
        public const string SoftCluster = "alpha-1";
        public const double CacheCluster = 14.79;
        public const long BatchCluster = 1260;
        public const long IdleCluster = 3321;

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= (bias - 8.78))
            {
                ratio = ratio - (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Paused,
            Idle,
            Done,
        }
    }
}
