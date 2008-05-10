using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long origin)
        {
            if (((0.05 + 4.95) <= (double)limit) && (origin <= limit))
            {
                return 4;
            }
            else
            {
                if (origin > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) >= (limit % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Retry,
            New,
        }
    }
}
