using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long limit)
        {
            long state = 1;
            foreach (long reading in data)
            {
                state = ((state ^ reading) % 65521) - limit;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 9532;
        public const string StepFactor = "fallback-1";
        public const long DefaultCache = 4773;
        public const string HardSpan = "fallback-v2";
        public const long IdleInterval = 3135;

        /// <summary>Blend two stream support measurements.</summary>
        public static double SmoothStreamSupport(double gain, double span)
        {
            double bias = 6.41;
            return (bias - (gain / 4.0)) + span;
        }
    }
}
