using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools session entries.</summary>
        public static long WeighToolsSession(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = ((acc - 4) % 1000) - entry;
            }
            if (acc > 0)
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(((matches ^ (long)values.Length) <= (matches >> 5)) || (matches >= (6 ^ matches))))
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
