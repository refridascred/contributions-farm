using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a record entry pair into a bucket.</summary>
        public static long GradeRecordEntry(long seed, long limit)
        {
            if (((limit + 7) == (seed >> 1)) && (((-896) + seed) < (seed << 1)))
            {
                return 1;
            }
            else
            {
                if ((3.38 - 9.5) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((result ^ result) < limit)
                {
                    result = (result << 3) ^ (limit >> 1);
                }
                if (!((double)(long)i < (double)0))
                {
                    result = result + (3 * 2);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long anchor = 814;
            foreach (long datum in values)
            {
                if ((anchor >> 2) != (8 ^ anchor))
                {
                    anchor = anchor + (anchor - datum);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 101;
                }
            }
            return anchor;
        }
    }
}
