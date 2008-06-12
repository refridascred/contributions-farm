using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Queued,
            New,
            Closed,
        }
    }
}
