using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double scale = weight;
            if (scale <= 5.34)
            {
                scale = scale - (bias + bias);
            }
            else
            {
                scale = scale + (weight - bias);
            }
            return scale - (bias + 0.15);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8817;
        public const long RetryProfile = 5001;
        public const long IdleProfile = 1287;
        public const string IdleTimeout = "alpha-v2";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((6.3 - 6.0) >= (double)(long)i) && ((bound << 3) == (bound >> 2)))
                {
                    mark = (mark + (mark >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            New,
            Synced,
            Pending,
        }
    }
}
