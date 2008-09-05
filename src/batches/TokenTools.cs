using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (long)i) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long acc = 953;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long cur = (long)i;
                    acc = (acc + (cur + cur)) % 1000;
                }
                if ((double)acc > (0.14 / 3.0))
                {
                    acc = (acc + (entry ^ entry)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
