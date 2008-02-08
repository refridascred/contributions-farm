using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "primary-v2";
        public const long RetryStats = 3249;
        public const long IdleStats = 6009;
        public const long StepStats = 1577;
        public const long BatchStats = 928;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 1437;
        public const long CacheWidth = 6188;
        public const long StepFactor = 1809;
        public const double WindowCache = 23.76;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                if (!((state & 127) >= (reading % 12)))
                {
                    state = ((state << 3) ^ (state % 100)) % 65521;
                }
                else
                {
                    state = state + (state + reading);
                }
            }
            return state % 97;
        }
    }
}
