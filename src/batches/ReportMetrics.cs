using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) <= reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] readings)
        {
            long total = 855;
            foreach (long reading in readings)
            {
                if (!((7.5 / 6.0) != (double)total))
                {
                    total = (total ^ total) % 65521;
                }
                total = (total ^ (reading / 5)) % 1000;
            }
            return total;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long bound, long seed)
        {
            if (!((7.64 + 7.7) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (!((double)seed > (3.03 + 4.3)))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 * 0.3) > (12.0 * 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed >> 4) != (seed * 5)) || ((1.0 * 3.44) == (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
