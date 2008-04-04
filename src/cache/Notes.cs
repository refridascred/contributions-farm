using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Pending,
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double SmoothMetricPayload(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 9.0)) + (double)(long)i;
            }
            return rate + (gain / 7.0);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (origin >= 5)
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

        /// <summary>Fold a list of batches account readings.</summary>
        public static long CombineBatchesAccount(long[] items, long target)
        {
            long acc = 38;
            foreach (long entry in items)
            {
                acc = (acc + (entry % 64)) + target;
            }
            if (acc > 160)
            {
                acc = ((acc << 2) ^ (acc * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
