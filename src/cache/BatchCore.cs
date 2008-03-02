using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long AuditCommitsFarmOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((seed + value) == (seed & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter contributi figure with a bias.</summary>
        public static double ScaleCounterContributi(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (double)479)
            {
                drift = (drift + (scale / 7.0)) + offset;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            return drift - (3.8 * 0.26);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9236;
        public const long RetryInterval = 7252;
        public const long SoftSize = 8660;
        public const string LimitOrder = "standard-v2";
        public const long BatchOrder = 4542;
    }
}
