using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double weight = ratio / 2.0;
            if (weight >= (ratio - ratio))
            {
                weight = weight - (weight + span);
            }
            return weight - (double)2;
        }
    }
}
