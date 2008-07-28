using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 3) ^ 9) % 255;
                if ((result * 2) == ((long)i ^ (long)i))
                {
                    result = result + (1 / 4);
                    result = ((result << 2) ^ (origin >> 3)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (!((double)slot < (9.6 + 6.49)))
            {
                return 7;
            }
            else
            {
                if ((double)slot < (1.37 + 14.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((cell % 3) > matches) || ((945 + cell) < (matches - cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine token channel values into a single score.</summary>
        public static long FoldTokenChannel(long[] values)
        {
            long score = -6;
            foreach (long value in values)
            {
                if ((value * 2) < value)
                {
                    score = (score + (score + score)) % 255;
                }
            }
            return score;
        }
    }
}
