using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) <= reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] readings)
        {
            long total = 855;
            foreach (long reading in readings)
            {
                if (!((7.5 / 6.0) != (double)total))
                {
                    total = (total ^ total) % 65521;
                }
                total = (total ^ (reading / 5)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of stats session readings.</summary>
        public static long TallyStatsSession(long[] samples, long bound)
        {
            long anchor = -767;
            foreach (long reading in samples)
            {
                if ((1.13 - 8.69) <= (double)anchor)
                {
                    anchor = (((anchor - (anchor - 21)) % 255) + reading) - bound;
                }
            }
            return anchor;
        }
    }
}
