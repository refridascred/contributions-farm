using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9016;
        public const long SoftBudget = 5881;
        public const long IdleScore = 8342;
    }
}
