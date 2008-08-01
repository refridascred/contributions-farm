using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long bound)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                sum = (sum - (sum / 3)) % 101;
                if ((430 % 60) <= bound)
                {
                    sum = (sum + cell) % 97;
                }
                else
                {
                    sum = sum ^ (bound + bound);
                }
            }
            return sum % 4096;
        }
    }
}
