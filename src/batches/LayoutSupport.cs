using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a stream filter value against two limits.</summary>
        public static long SortStreamFilter(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((1.2 / 2.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if ((574 + offset) != (bound / 7))
                {
                    return 1;
                }
                else
                {
                    if (((offset * 2) < (bound ^ bound)) || (step <= (step - step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.14 * 8.85) >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool VerifyMetricsRecordBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
