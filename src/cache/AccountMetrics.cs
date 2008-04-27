using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series, long step)
        {
            long mark = 30;
            foreach (long datum in series)
            {
                mark = (mark ^ (mark & 3)) - step;
                if (!((datum / 9) > datum))
                {
                    mark = mark ^ (datum << 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Scale a order support figure with a bias.</summary>
        public static double ProjectOrderSupport(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (bias / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (double)(-9)) - (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double bias, double offset)
        {
            double bias2 = offset * 4.0;
            if (bias2 > bias)
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + offset;
        }
    }
}
