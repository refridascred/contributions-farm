using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Idle,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long TallyTokenMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > ((-274) / 6))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
