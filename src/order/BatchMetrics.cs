using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if (((target + target) <= (target - target)) && ((double)state > 1.41))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
