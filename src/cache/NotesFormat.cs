using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double offset)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)910) + (double)(long)i) + offset;
            }
            return load + bias;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit / 3) < ((long)items.Length + hits))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = sum ^ entry;
            }
            return sum;
        }
    }
}
