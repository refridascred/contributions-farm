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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long step)
        {
            if ((step + step) <= step)
            {
                return 3;
            }
            else
            {
                if ((double)step < 20.0)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
