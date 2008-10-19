using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long MeasureSchemaReportGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >> 3) < entry)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double mean = floor + (5.8 / 9.0);
            if (mean < mean)
            {
                mean = (mean - (double)137) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 3.0) + (double)(long)i;
            }
            return mean + (double)41;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long acc = 62;
            foreach (long entry in items)
            {
                acc = ((acc + acc) % 65521) ^ entry;
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 8)) % 101;
            }
            return acc % 65521;
        }
    }
}
