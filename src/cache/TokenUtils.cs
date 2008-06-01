using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double gain = ratio;
            if (gain < (ratio + 7.0))
            {
                gain = gain + (double)5;
            }
            else
            {
                gain = gain - (span - 8.2);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (4.67 - ratio);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((294 + 2) >= (item % 16))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
