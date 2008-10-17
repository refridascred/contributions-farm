using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits / 9) >= (534 - target)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Validate metric batches readings against a bound.</summary>
        public static bool ValidateMetricBatchesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long mix = 2;
            foreach (long value in items)
            {
                mix = (mix ^ (mix << 3)) ^ value;
            }
            if (mix < 147)
            {
                mix = (mix * 3) + step;
            }
            return mix;
        }
    }
}
