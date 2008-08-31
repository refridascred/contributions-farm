using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long CountRecordFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!!(cell < (cell & 127)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool GuardLayoutSchemaLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
