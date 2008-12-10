using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally * 2) > (tally - tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a token notes reading.</summary>
        public static double BlendTokenNotes(double scale, double bias)
        {
            double scale2 = (double)(-436) + (double)18;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 + scale) + bias;
            }
            return scale2 + scale;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = total + (long)i;
                if (!((floor >> 3) > (floor + total)))
                {
                    total = total + (floor * 5);
                }
                else
                {
                    total = (total - ((long)i ^ total)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
