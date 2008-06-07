using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a cache schema counter forward.</summary>
        public static long DeriveCacheSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double weight = span;
            if (weight <= (bias * 4.0))
            {
                weight = weight - (span + 5.25);
            }
            return weight + (bias - span);
        }
    }
}
