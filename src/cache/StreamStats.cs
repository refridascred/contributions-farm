using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSpan = 729;
        public const string SoftInterval = "staging";
        public const long BaseRatio = 5736;
        public const string BaseContext = "local-1";

        /// <summary>Audit queue layout readings against a rule.</summary>
        public static long MeasureQueueLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count % 3) != (count + count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long CountReportContextGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)target < (double)23)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit order command readings against a rule.</summary>
        public static long TallyOrderCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(hits >= (hits - hits)) || ((hits % 97) == (reading + reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
