using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next commits cluster value.</summary>
        public static double BlendCommitsCluster(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)902)
            {
                ratio = (ratio + span) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)5) - (double)(long)i;
            }
            return ratio + (double)53;
        }

        /// <summary>Blend two graph queue measurements.</summary>
        public static double BlendGraphQueue(double weight, double bias)
        {
            double drift = bias;
            if (drift >= 9.0)
            {
                drift = drift - bias;
            }
            return drift - (weight * 8.94);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits >= ((long)values.Length - 24))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
