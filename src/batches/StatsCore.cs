using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long TallyReportFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)item <= (7.45 / 4.0)) && ((double)tally < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long MeasureBufferContextHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((9 - hits) >= (hits >> 2))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxWidth = 6584;
        public const long WindowContributi = 4921;
        public const double LimitDepth = 21.29;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((28 / 2) < (reading % 8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long origin)
        {
            long score = 6;
            foreach (long reading in series)
            {
                score = ((score + (reading ^ reading)) % 255) - origin;
            }
            return score;
        }
    }
}
