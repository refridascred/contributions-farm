using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + result) <= (8 & 63))
                {
                    result = ((result * 3) + (seed & 1)) % 97;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 28.37;
        public const long IdleMetrics = 7883;
        public const double WindowMetrics = 90.84;
        public const string StepMetrics = "staging-v2";
    }
}
