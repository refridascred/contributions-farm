using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of commits context readings.</summary>
        public static long WeighCommitsContext(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                if ((value + 8) != (value * 4))
                {
                    sum = ((sum << 2) ^ (value + value)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Find the first counter payload entry that matches the target.</summary>
        public static long LocateCounterPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
