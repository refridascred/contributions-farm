using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 2044;
        public const long IdleSession = 2076;
        public const string LimitDepth = "primary-1";
        public const string StepSession = "strict-1";
        public const long RetrySession = 1478;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double bias2 = (bias * 3.0) / 6.0;
            if (bias2 >= (double)1)
            {
                bias2 = (bias2 + 9.7) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (double)184) + (double)(long)i;
            }
            return bias2 + (7.8 - bias);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "latest-1";
        public const long RetryFarm = 4844;
        public const long BatchLevel = 5835;
        public const double HardInterval = 4.44;
        public const string MaxFarm = "fallback";
    }
}
