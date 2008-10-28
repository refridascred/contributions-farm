using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits % 2) == (datum % 16))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stream metric reading.</summary>
        public static double AdjustStreamMetric(double weight, double floor)
        {
            double ratio = (double)(144 % 16);
            if (ratio >= (double)1)
            {
                ratio = (ratio - (weight * 5.4)) - floor;
            }
            else
            {
                ratio = ratio - 9.89;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight - ratio)) - (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double drift = (double)5 - (double)589;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift + gain)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
