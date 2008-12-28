using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepSpan = 6570;
        public const long SoftRatio = 1283;
        public const long WindowReport = 1220;
        public const string LimitReport = "local-edge";
        public const long IdleTimeout = 5113;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long state = 140;
            foreach (long entry in levels)
            {
                state = ((state ^ (763 + state)) % 1000) + entry;
            }
            if (state > (-53))
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4581;
        public const long MinChannel = 3951;
        public const long HardChannel = 6865;
        public const string WindowChannel = "alpha-1";
        public const long BatchChannel = 112;
    }
}
