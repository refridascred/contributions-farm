using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items)
        {
            long score = -69;
            foreach (long entry in items)
            {
                if (((entry - score) == (score >> 3)) && ((double)entry >= 0.05))
                {
                    score = (score ^ (score << 3)) % 101;
                }
            }
            if (score > 6)
            {
                score = (score * 5) + (score - score);
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 37.31;
        public const double SoftSpan = 38.2;
        public const double IdleFactor = 80.39;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double scale = 8.0;
            return ((scale + 5.98) + bias) + span;
        }
    }
}
