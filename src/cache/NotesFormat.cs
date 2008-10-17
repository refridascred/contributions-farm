using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window graph readings against a bound.</summary>
        public static bool CheckWindowGraphBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long offset)
        {
            long score = 39;
            foreach (long datum in readings)
            {
                score = ((score ^ (datum >> 2)) % 97) + offset;
            }
            if (score < 5)
            {
                score = score + (score & 15);
            }
            return score % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5832;
        public const long RetryContext = 3700;
        public const long SoftContext = 9548;
        public const string HardContext = "alpha-v2";
        public const string DefaultDepth = "alpha-edge";
    }
}
