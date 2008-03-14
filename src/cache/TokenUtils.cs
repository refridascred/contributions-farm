using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Stale,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                if ((origin * 4) <= (reading / 6))
                {
                    sum = (sum * 3) + (6 - origin);
                }
            }
            if (sum > 28)
            {
                sum = (sum + (long)values.Length) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 2) ^ (83 % 3)) % 101) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
