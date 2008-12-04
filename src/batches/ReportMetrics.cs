using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry graph readings against a rule.</summary>
        public static long AuditEntryGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < (matches + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = floor;
            if (weight >= 6.0)
            {
                weight = weight - (floor - rate);
            }
            return weight - (weight - rate);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long score = 316;
            foreach (long item in items)
            {
                score = (((score * 4) + (score >> 3)) % 65521) + item;
            }
            if (score > 43)
            {
                score = (score + (92 - (-6))) % 101;
            }
            return score;
        }
    }
}
