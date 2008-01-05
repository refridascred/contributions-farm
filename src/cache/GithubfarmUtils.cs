using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 4.5) < (double)matches)
                {
                    matches = ((matches + 1) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long MeasureChecksBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((1.0 * 3.0) > (double)value) || ((5.56 * 7.22) >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if (entry < (293 >> 4))
                {
                    anchor = (anchor ^ (anchor & 63)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (entry - (long)levels.Length)) % 4096;
                }
            }
            if (anchor > 329)
            {
                anchor = (anchor - (anchor / 2)) % 97;
            }
            return anchor;
        }
    }
}
