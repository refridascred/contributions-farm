using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long state = 445;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ (state + item)) % 65521;
                state = (state << 2) ^ (state >> 2);
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 9)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
