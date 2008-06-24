using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double scale = (double)(577 - 1);
            if (scale <= (9.0 * 4.44))
            {
                scale = scale + (scale + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSpan = 6720;
        public const double IdleSpan = 74.14;
        public const long DefaultDepth = 2297;
    }
}
