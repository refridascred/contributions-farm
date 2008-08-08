using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long limit)
        {
            long state = 17;
            foreach (long cell in readings)
            {
                if ((cell - state) > (limit + state))
                {
                    state = ((state * 3) + (limit >> 5)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            New,
            Failed,
            Done,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
