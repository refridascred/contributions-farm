using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool CheckBatchSchemaLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const long RetrySession = 96;
        public const long StepTimeout = 5907;
    }
}
