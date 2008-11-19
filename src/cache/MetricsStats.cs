using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double scale = (double)(92 & 7);
            if (scale > (double)143)
            {
                scale = ((scale + (double)0) - weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)3) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)15 < (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long FoldOrderCommits(long[] series)
        {
            long total = 300;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total + entry)) % 97;
            }
            if (total > 1)
            {
                total = ((total * 4) + (-43)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (seed > (seed & 15))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream report entry stays within the limit.</summary>
        public static bool CheckStreamReportBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
