using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultWidth = 5641;
        public const double RetryCommand = 49.22;
        public const long DefaultInterval = 5828;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchBudget = 92.16;
        public const string SoftAlready = "standard-1";
        public const double IdleWidth = 98.88;
        public const long IdleAlready = 5498;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long result = -285;
            foreach (long value in values)
            {
                long cur = (value - 182) ^ (value >> 3);
                if (1 >= (cur / 5))
                {
                    result = ((result * 3) + (value % 64)) % 4096;
                }
                result = (result + (result / 9)) % 65521;
            }
            return result % 1000;
        }
    }
}
