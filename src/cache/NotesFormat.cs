using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "primary-edge";
        public const string RetryContext = "fallback-1";
        public const long BurstTimeout = 1103;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine contributi route values into a single score.</summary>
        public static long CombineContributiRoute(long[] data)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if ((sample < (91 + sample)) || ((0.5 + 3.1) > (double)anchor))
                {
                    anchor = (anchor << 3) ^ (sample / 5);
                }
            }
            return anchor;
        }
    }
}
