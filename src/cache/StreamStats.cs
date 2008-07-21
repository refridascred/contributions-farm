using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next batches cache value.</summary>
        public static double SmoothBatchesCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor - ratio))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)59) - (double)(long)i;
            }
            return drift + (ratio / 7.0);
        }

        /// <summary>Match up editor queue samples.</summary>
        public static long MatchEditorQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryRatio = 49.86;
        public const string LimitCluster = "stable-v2";
        public const string StepTimeout = "legacy-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) >= (reading & 7))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
