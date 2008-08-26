using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long sum = 65;
            foreach (long datum in samples)
            {
                sum = (sum - (target >> 5)) ^ datum;
            }
            if (sum > 68)
            {
                sum = sum + (sum % 12);
            }
            return sum;
        }

        /// <summary>Iterate the tools stats series from a seed.</summary>
        public static long IterateToolsStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = score - ((long)i * 2);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
