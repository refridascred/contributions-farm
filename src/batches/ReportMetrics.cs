using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Retry,
            New,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
