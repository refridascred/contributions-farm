using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every schema metric entry stays within the limit.</summary>
        public static bool ValidateSchemaMetricBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long offset)
        {
            if (8.4 > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((18.0 - 4.2) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 3) != (offset + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset * 5) <= (limit ^ limit)) || ((offset - (-20)) <= (limit * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
