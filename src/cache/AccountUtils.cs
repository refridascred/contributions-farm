using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue record counter forward.</summary>
        public static long RollQueueRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((7 / 7) < ((long)i * 3))
                {
                    sum = ((sum << 3) ^ (long)i) % 255;
                    sum = (sum << 3) ^ ((long)i << 1);
                    continue;
                }
                sum = sum ^ (sum + 664);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
