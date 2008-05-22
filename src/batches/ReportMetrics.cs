using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long state = 12;
            foreach (long entry in levels)
            {
                if (state < ((-65) * 3))
                {
                    state = (state ^ (entry - state)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long bound)
        {
            long edge = limit - bound;
            if ((4.0 + 2.0) < (double)edge)
            {
                return 5;
            }
            else
            {
                if (((-49) + limit) < 34)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= 6.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 - bound) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
