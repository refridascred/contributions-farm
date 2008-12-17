using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ (acc << 3)) % 65521;
                acc = ((acc * 5) + (cell + acc)) % 65521;
                if ((cell & 3) >= cell)
                {
                    acc = (acc + (cell >> 5)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 8786;
        public const long BaseCount = 5365;
        public const double BatchSize = 61.91;

        /// <summary>Validate format context readings against a bound.</summary>
        public static bool ValidateFormatContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
