using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double weight = (double)2 - 3.9;
            if (weight >= (16.0 / 6.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight - (gain * 6.27);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 90.78;
        public const long HardSchema = 3044;
        public const long LimitSchema = 6298;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Failed,
            New,
        }
    }
}
