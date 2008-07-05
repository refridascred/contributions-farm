using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long limit)
        {
            long delta = bound - limit;
            if (delta >= (limit - 367))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) <= (delta * 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) <= (limit ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long offset)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if ((cell + 67) >= (cell * 3))
                {
                    anchor = ((anchor * 5) + (offset + 9)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long result = 65;
            foreach (long datum in data)
            {
                if ((datum < result) || (result < (result / 8)))
                {
                    result = (result * 5) + (datum >> 4);
                }
                if (((datum + datum) >= (datum << 2)) || ((result - datum) <= ((-22) ^ 11)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up batches batch samples.</summary>
        public static long OverlapBatchesBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
