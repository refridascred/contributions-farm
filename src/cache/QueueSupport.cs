using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2776;
        public const long SoftGraph = 2031;
        public const long DefaultGraph = 8297;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 / 6.0) < (double)result)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many farm account samples are out of range.</summary>
        public static long CountFarmAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-80) + item) > (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
