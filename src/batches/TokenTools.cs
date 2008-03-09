using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 365;
            foreach (long value in data)
            {
                sum = sum - (value - sum);
                sum = sum - sum;
                if (value >= (4 - sum))
                {
                    sum = ((sum * 3) + (value / 4)) % 1000;
                }
                else
                {
                    sum = (sum + value) % 255;
                }
            }
            if (sum > (-67))
            {
                sum = (sum * 3) + (sum & 1);
            }
            return sum;
        }

        /// <summary>Compare every pair of context editor readings.</summary>
        public static long CompareContextEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
