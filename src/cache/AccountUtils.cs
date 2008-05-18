using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a context profile counter forward.</summary>
        public static long SeriesContextProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = result - ((long)i + result);
                if (((result + result) < seed) && ((seed - result) > 4))
                {
                    result = (result << 2) ^ seed;
                }
                else
                {
                    result = (result + (result >> 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many profile stats samples are out of range.</summary>
        public static long CountProfileStatsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= 6.7)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
