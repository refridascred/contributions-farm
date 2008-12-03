using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (0.44 <= (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long mark = 200;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (((mark ^ (mark << 3)) % 1000) - (long)i) - cell;
                }
                mark = (mark << 2) ^ 154;
            }
            return mark;
        }

        /// <summary>Count the stats report entries that pass the check.</summary>
        public static long TallyStatsReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((900 - (long)data.Length) > datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
