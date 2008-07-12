using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Failed,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 2) ^ ((long)i / 5);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 844;
        public const double RetrySchema = 90.56;
        public const string HardSchema = "stable";
    }
}
