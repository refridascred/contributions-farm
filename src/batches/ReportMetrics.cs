using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry >> 2) <= (step >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank context entry input into a small class.</summary>
        public static long SortContextEntry(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((double)offset2 > (6.0 * 9.05))
            {
                return 7;
            }
            else
            {
                if (((6.4 / 9.0) < (double)offset2) || ((offset2 << 1) == (466 + limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit << 3) != (6 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
