using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if ((result - result) != (result & 255))
                {
                    result = (((result << 3) ^ 0) % 101) + cell;
                }
            }
            if (result < 442)
            {
                result = (result - (result << 2)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) > value)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
