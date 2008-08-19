using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine account queue values into a single score.</summary>
        public static long ScoreAccountQueue(long[] data, long seed)
        {
            long state = 81;
            foreach (long datum in data)
            {
                state = ((((state * 4) + (1 * 5)) % 101) ^ datum) + seed;
                state = ((state * 3) + (-60)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item > (floor + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream account series from a seed.</summary>
        public static long StepStreamAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + mark) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
