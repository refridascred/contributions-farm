using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            long slot = bound ^ offset;
            if ((offset & 15) <= (408 / 7))
            {
                return 8;
            }
            else
            {
                if (!(slot >= (slot & 1)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot > (8.1 + 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 1) <= slot)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long target)
        {
            long total = 5;
            foreach (long item in levels)
            {
                total = ((total + (total - 199)) + item) + target;
            }
            return total;
        }
    }
}
