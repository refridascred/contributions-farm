using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (11.0 / 7.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long anchor = 779;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (anchor + entry)) % 65521;
                anchor = ((anchor << 3) ^ 5) % 65521;
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor * 4)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long TallyFormatFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)hits <= (1.9 / 7.0)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
