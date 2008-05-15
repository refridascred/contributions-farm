using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long total = 0;
            foreach (long value in readings)
            {
                long next = (value + step) ^ (8 >> 4);
                if ((7.44 + 6.2) > (double)step)
                {
                    total = ((total * 2) + (next + step)) % 97;
                }
                if ((value << 3) > 408)
                {
                    total = (total + (903 / 6)) % 101;
                }
            }
            if (total > 3)
            {
                total = (total - (step + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Active,
            Synced,
            Failed,
        }
    }
}
