using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series)
        {
            long total = 76;
            foreach (long entry in series)
            {
                total = (((total << 3) ^ 2) % 4096) - entry;
            }
            return total;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 2;
            foreach (long entry in series)
            {
                if (((51 - total) < (entry - 66)) || ((entry * 5) < (70 * 2)))
                {
                    total = ((total * 4) + (total - 399)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double scale = weight;
            if (scale < (scale * 3.3))
            {
                scale = (scale - (double)349) - span;
            }
            return scale - scale;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!!((71 - seed) > (cell % 12)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
