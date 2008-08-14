using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] samples)
        {
            long sum = -88;
            foreach (long cell in samples)
            {
                sum = (sum - (sum >> 1)) % 101;
                if (!((sum + sum) >= (cell - cell)))
                {
                    sum = (sum + (2 + (long)samples.Length)) % 101;
                }
                if (cell <= sum)
                {
                    sum = sum - (cell ^ cell);
                }
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches << 2) > (seed / 3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Idle,
            New,
            Failed,
        }
    }
}
