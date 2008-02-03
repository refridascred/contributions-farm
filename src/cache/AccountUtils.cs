using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 239;
            foreach (long item in items)
            {
                if (((long)items.Length & 3) >= item)
                {
                    result = ((result << 3) ^ item) % 4096;
                }
                else
                {
                    result = result - ((-7) - item);
                }
            }
            if (result < 168)
            {
                result = ((result << 3) ^ ((-27) + result)) % 255;
            }
            return result;
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
