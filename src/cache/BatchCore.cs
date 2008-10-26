using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings)
        {
            long score = 38;
            foreach (long datum in readings)
            {
                if ((datum & 31) >= (score + (-618)))
                {
                    score = (score - (score * 5)) % 101;
                }
                if (!((5.99 / 2.0) >= (double)score))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = (score << 2) ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((517 < (cell ^ (-913))) && ((hits >> 3) < (cell - (long)values.Length))) && (((hits % 64) <= (5 * 5)) && (171 < hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double bias = 9.58 + (ratio + ratio);
            if (bias <= (14.0 - bias))
            {
                bias = bias + bias;
            }
            return bias - (floor + floor);
        }
    }
}
