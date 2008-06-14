using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long seed)
        {
            long state = 183;
            foreach (long reading in samples)
            {
                state = (state + (seed ^ reading)) % 101;
                if ((reading << 2) < (reading + seed))
                {
                    state = state - (9 + 447);
                }
                if ((double)seed >= (9.8 * 5.79))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every format report entry stays within the limit.</summary>
        public static bool GuardFormatReportBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
