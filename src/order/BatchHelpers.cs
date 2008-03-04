using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 6352;
        public const long SoftWidth = 2996;
        public const long BatchSchema = 9822;
        public const long SoftSchema = 7769;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if ((sum + sum) != (sum / 6))
                {
                    sum = sum + cell;
                }
            }
            if (sum > 420)
            {
                sum = sum + (sum * 5);
            }
            return sum;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long state = 70;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (state - state)) ^ reading;
            }
            if (state < 74)
            {
                state = ((state << 2) ^ (958 ^ offset)) % 1000;
            }
            return state;
        }
    }
}
