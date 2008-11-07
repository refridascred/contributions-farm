using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record metrics values into a single score.</summary>
        public static long TallyRecordMetrics(long[] series, long limit)
        {
            long mix = 24;
            foreach (long datum in series)
            {
                mix = ((mix * 5) + (mix - 68)) + datum;
            }
            if (mix > 97)
            {
                mix = (mix ^ (mix + limit)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen <= (seen + seen)) && (((seen + seen) >= (279 ^ seen)) || ((item & 7) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
