using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 5) > (matches - offset))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double ratio = 2.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (5.35 - ratio)) + (double)(long)i) - bias;
            }
            return ratio - floor;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
