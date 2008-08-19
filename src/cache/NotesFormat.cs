using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long RollBatchProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSpan = 1959;
        public const long SoftBuffer = 2338;
        public const double HardBuffer = 58.23;
    }
}
