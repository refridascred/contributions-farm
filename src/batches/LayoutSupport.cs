using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double ratio = 5.67;
            if (ratio >= 9.6)
            {
                ratio = (ratio - (double)7) - offset;
            }
            return ratio + scale;
        }

        /// <summary>Accumulate tools farm samples.</summary>
        public static long ScoreToolsFarm(long[] levels, long seed)
        {
            long score = 332;
            foreach (long sample in levels)
            {
                if ((score % 60) > (seed + seed))
                {
                    score = (score - (score >> 3)) % 255;
                }
                else
                {
                    score = (score - (sample & 31)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit report commits readings against a rule.</summary>
        public static long CountReportCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >> 3) != (cell % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long AuditBufferChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - 5) < (datum ^ 18))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
