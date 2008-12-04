using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = (double)(4 % 3);
            if (drift < (double)7)
            {
                drift = (drift - (double)45) - offset;
            }
            return drift + gain;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 2912;
        public const string IdleWidth = "local-v2";
        public const long MinSupport = 604;
        public const string BatchCount = "cached-edge";
        public const long BaseScore = 2430;

        /// <summary>Adjust a buffer profile reading.</summary>
        public static double ScaleBufferProfile(double rate, double offset)
        {
            double weight = rate;
            return (weight - weight) + offset;
        }
    }
}
