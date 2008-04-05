using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long floor, long origin)
        {
            if (!((floor ^ origin) != (825 + floor)))
            {
                return 2;
            }
            else
            {
                if ((floor - origin) > floor)
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) < (origin - origin)) || ((double)floor == (0.38 + 2.8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (item - 388))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a tools graph figure with a bias.</summary>
        public static double BlendToolsGraph(double scale, double offset)
        {
            double mean = 16.0;
            if (mean < scale)
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset / 8.0)) - (double)(long)i;
            }
            return mean + (double)642;
        }
    }
}
