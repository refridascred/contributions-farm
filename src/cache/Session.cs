using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (7.38 / 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (limit & 3)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long bound)
        {
            long edge = floor - bound;
            if ((double)floor >= (9.22 + 5.9))
            {
                return 1;
            }
            else
            {
                if ((2 << 3) == (bound / 5))
                {
                    return 3;
                }
                else
                {
                    if ((double)87 != (double)edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
