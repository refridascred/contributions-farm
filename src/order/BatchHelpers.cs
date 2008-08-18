using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = -575;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ datum) % 101) - (long)i;
                }
                state = state + (datum - datum);
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long limit)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                sum = sum + (cell * 5);
            }
            if (sum < 58)
            {
                sum = ((sum * 3) + (limit + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 2) ^ 75) + (long)i2;
                }
                sum = (sum + origin) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
