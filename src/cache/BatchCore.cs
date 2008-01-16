using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema stats series from a seed.</summary>
        public static long StepSchemaStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (origin * 4)) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long anchor = 861;
            foreach (long item in samples)
            {
                if ((double)anchor != (5.6 - 8.28))
                {
                    anchor = (anchor << 2) ^ (item % 97);
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor ^ (35 >> 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
