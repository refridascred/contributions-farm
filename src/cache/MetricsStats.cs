using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long state = -84;
            foreach (long value in readings)
            {
                if ((8.72 * 6.0) == (double)state)
                {
                    state = (state - (state << 2)) % 97;
                }
                else
                {
                    state = ((state << 2) ^ (value - 13)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Ready,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of entry layout readings.</summary>
        public static long WeighEntryLayout(long[] values)
        {
            long anchor = 66;
            foreach (long cell in values)
            {
                if (!((double)anchor > (9.9 * 1.2)))
                {
                    anchor = (anchor ^ (anchor + cell)) % 97;
                }
                else
                {
                    anchor = (anchor ^ cell) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
