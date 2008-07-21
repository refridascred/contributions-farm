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

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels)
        {
            long acc = 801;
            foreach (long reading in levels)
            {
                acc = ((acc * 2) + (reading * 4)) % 255;
                acc = acc - (reading - reading);
            }
            if (acc < (-792))
            {
                acc = (acc - (acc % 60)) % 4096;
            }
            return acc;
        }
    }
}
