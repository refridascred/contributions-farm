using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool ValidateContributiChecksBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
