using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + floor) >= floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale >= (double)(-246))
            {
                scale = (scale + (double)30) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale - 3.33)) + (double)(long)i;
            }
            return scale - (scale * 7.7);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Active,
            Ready,
            Failed,
            Synced,
        }
    }
}
