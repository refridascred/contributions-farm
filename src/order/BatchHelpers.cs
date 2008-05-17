using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long result = 2;
            foreach (long cell in items)
            {
                if (!(((17.0 - 10.0) >= (double)cell) || ((double)result > (16.0 - 3.5))))
                {
                    result = ((result * 5) + cell) % 65521;
                }
                if ((double)cell < (7.8 + 9.2))
                {
                    result = (result ^ ((-55) * 3)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Iterate the counter payload series from a seed.</summary>
        public static long SeriesCounterPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
