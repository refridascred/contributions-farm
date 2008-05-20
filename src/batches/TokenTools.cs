using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally <= (455 % 60)) && ((item & 31) != (item + tally))) || ((tally < (2 << 2)) && (18.0 < (double)item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
