using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Queued,
            Done,
        }

        /// <summary>Locate a commits account reading by value.</summary>
        public static long FindCommitsAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowBudget = 1397;
        public const string BaseAccount = "open-1";
        public const string WindowAccount = "cached-edge";
        public const double MinAccount = 75.12;
        public const long SoftSize = 4879;

        /// <summary>Audit graph support readings against a rule.</summary>
        public static long CountGraphSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (double)4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
