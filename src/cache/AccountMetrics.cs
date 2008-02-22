using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double drift = (bias / 6.0) - 20.0;
            if (drift <= 16.0)
            {
                drift = drift + (span - 4.23);
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a report buffer sample.</summary>
        public static long LookupReportBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items, long floor)
        {
            long mark = 314;
            foreach (long entry in items)
            {
                if (!(mark >= (167 << 2)))
                {
                    mark = ((mark * 3) + (floor / 3)) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 56;
            foreach (long cell in data)
            {
                if (63 <= (cell + 1))
                {
                    acc = acc + (cell % 12);
                }
            }
            return acc % 1000;
        }
    }
}
