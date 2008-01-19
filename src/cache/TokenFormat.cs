using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long offset)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if (((50 & 127) <= sum) || (offset >= (offset % 10)))
                {
                    sum = (sum ^ (sum ^ 7)) ^ entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up session queue samples.</summary>
        public static long OverlapSessionQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate graph account readings against a bound.</summary>
        public static bool ValidateGraphAccountRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
