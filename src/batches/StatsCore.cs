using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseInterval = "cached";
        public const long BurstEntry = 470;
        public const double RetryEntry = 4.55;
        public const long IdleEntry = 467;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
