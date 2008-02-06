using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of context already readings.</summary>
        public static long OverlapContextAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 4) <= (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 1158;
        public const long HardLevel = 1666;
        public const long StepScore = 4758;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values, long bound)
        {
            long total = 0;
            foreach (long cell in values)
            {
                if ((total ^ cell) <= (bound & 7))
                {
                    total = (total * 3) + (total & 15);
                }
                else
                {
                    total = (total * 5) + (bound << 3);
                }
                total = total ^ (bound << 2);
                total = (total << 2) ^ cell;
            }
            return total;
        }
    }
}
