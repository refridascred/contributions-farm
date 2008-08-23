using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long step)
        {
            long total = 1;
            foreach (long cell in items)
            {
                if ((step - step) < (step ^ total))
                {
                    total = (total ^ ((-6) + cell)) % 255;
                }
                else
                {
                    total = (total * 4) + cell;
                }
            }
            if (total > 8)
            {
                total = ((total * 5) + (15 >> 1)) % 255;
            }
            return total % 97;
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double scale = (double)587 * 1.8;
            if (scale >= 2.68)
            {
                scale = (scale - floor) + bias;
            }
            return scale - (scale - scale);
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
