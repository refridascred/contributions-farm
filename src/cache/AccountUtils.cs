using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a graph notes counter forward.</summary>
        public static long IterateGraphNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((floor * 4) < anchor))
                {
                    anchor = anchor ^ (floor / 9);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the format report series from a seed.</summary>
        public static long StepFormatReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total + (total >> 1)) ^ (long)i2;
                    total = (total + (total % 12)) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long TallyMetricReportHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 3) >= (long)items.Length) && !((count ^ (-682)) < (datum + count)))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
