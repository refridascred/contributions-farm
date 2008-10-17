using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "staging-edge";
        public const string CacheMetric = "primary-1";
        public const long RetryTimeout = 8901;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 11.51;
        public const long MinSession = 4069;
        public const double MaxSession = 54.63;
        public const long MaxInterval = 9251;
        public const long BatchTimeout = 1235;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step * 2) <= (step - matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
