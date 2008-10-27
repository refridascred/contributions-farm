using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long step)
        {
            long anchor = 11;
            foreach (long sample in series)
            {
                if ((anchor & 63) >= (sample >> 2))
                {
                    anchor = ((anchor + (100 * 5)) % 101) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double weight = 5.1 / 2.0;
            return (weight - ratio) + span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowScore = 19.75;
        public const string BaseTools = "staging-v2";
        public const double WindowTools = 96.5;
        public const string LimitCount = "staging-edge";
        public const double LimitTimeout = 61.26;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Draft,
            Pending,
        }
    }
}
