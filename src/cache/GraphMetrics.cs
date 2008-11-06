using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long total = 538;
            foreach (long entry in levels)
            {
                total = (((total + (-47)) % 1000) - entry) - limit;
            }
            return total % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample * 5) < (sample ^ sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Paused,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Draft,
            New,
            Done,
            Queued,
        }
    }
}
