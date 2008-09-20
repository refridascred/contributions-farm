using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = total ^ (881 >> 2);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = 1.4;
            if (load >= (load / 2.0))
            {
                load = (load + (floor * 6.32)) + scale;
            }
            else
            {
                load = load - 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 5.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long target)
        {
            if ((8.43 - 10.0) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)bound >= (6.0 / 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((target < (4 - 57)) || ((14.0 * 3.1) != (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
