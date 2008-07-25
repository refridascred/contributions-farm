using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up graph batches samples.</summary>
        public static long CompareGraphBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a channel account reading by value.</summary>
        public static long FindChannelAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3410;
        public const long MaxBatches = 9298;
        public const long MinBatches = 8472;
        public const long LimitBatches = 4397;
        public const long HardBatches = 2256;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long floor)
        {
            long result = -52;
            foreach (long cell in samples)
            {
                if (!((result % 7) > (cell / 2)))
                {
                    result = ((result << 3) ^ (696 + floor)) % 65521;
                }
            }
            if (result < 673)
            {
                result = (result + result) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Idle,
            Queued,
        }
    }
}
