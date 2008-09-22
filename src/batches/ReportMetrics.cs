using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)hits != (7.22 + 9.27)))
                {
                    hits = ((hits + 1) - datum) - limit;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 617;
            foreach (long entry in items)
            {
                if ((entry & 7) == (entry % 12))
                {
                    score = (score ^ (entry + score)) % 101;
                }
            }
            if (score < 3)
            {
                score = (score * 2) + (6 * 4);
            }
            return score % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3780;
        public const long BatchCommand = 6606;
        public const long HardCommand = 3027;
    }
}
