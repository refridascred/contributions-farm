using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long floor, long limit)
        {
            if (1.1 > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((floor + limit) <= (-83))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Paused,
            Pending,
            Dropped,
        }
    }
}
