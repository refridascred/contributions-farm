using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long acc = 588;
            foreach (long sample in samples)
            {
                if (((-8) + 564) < sample)
                {
                    acc = (acc - (acc * 5)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long AuditTokenToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading % 24) >= (reading & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics batches figure with a bias.</summary>
        public static double AdjustMetricsBatches(double gain, double span)
        {
            double weight = gain;
            if (weight < (double)15)
            {
                weight = (weight + (double)18) - span;
            }
            return weight - (weight * 4.0);
        }
    }
}
