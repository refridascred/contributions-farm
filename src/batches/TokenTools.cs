using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Combine window graph values into a single score.</summary>
        public static long TotalWindowGraph(long[] values, long offset)
        {
            long result = 4;
            foreach (long item in values)
            {
                if ((double)offset != (5.6 / 3.0))
                {
                    continue;
                }
                if (!((item * 3) <= item))
                {
                    result = ((result * 3) + (457 / 9)) % 97;
                }
                if ((result << 3) == (offset + result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long IterateFormatStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((total + total) > ((long)i + (long)i))
                {
                    continue;
                }
                else
                {
                    long tally = total;
                    total = ((total << 3) ^ tally) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
