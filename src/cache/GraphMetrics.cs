using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            if ((step > (0 << 2)) && (step > (origin + step)))
            {
                return 2;
            }
            else
            {
                if (!(origin <= step))
                {
                    return 1;
                }
                else
                {
                    if (origin > 5)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 15) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double ScaleSchemaQueue(double weight, double offset)
        {
            double scale = weight;
            if (scale < (8.0 - offset))
            {
                scale = scale - (weight + 7.2);
            }
            return scale + (0.78 * 3.06);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 8) < (tally ^ datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 7651;
        public const long SoftSize = 7511;
        public const long BatchCluster = 8325;
    }
}
