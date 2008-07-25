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

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double bias)
        {
            double bias2 = weight;
            return bias2 + bias;
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
