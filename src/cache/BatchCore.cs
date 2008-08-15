using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if ((bound + bound) < floor)
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) <= (floor % 24))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items)
        {
            long anchor = 603;
            foreach (long entry in items)
            {
                if ((anchor < entry) || (anchor > (entry - anchor)))
                {
                    anchor = (anchor + (entry / 5)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long CompareSupportLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
