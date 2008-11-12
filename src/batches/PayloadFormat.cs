using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Check that every metrics session entry stays within the limit.</summary>
        public static bool VerifyMetricsSessionBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 116;
        public const long MinEditor = 7966;
        public const long RetryEditor = 6621;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
