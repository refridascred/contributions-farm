using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((origin ^ 538) >= 849)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 5731;
        public const long BatchPayload = 3234;
        public const long IdlePayload = 9551;
        public const long SoftRatio = 7192;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7971;
        public const double SoftCommand = 17.11;
        public const string HardCount = "legacy-v2";
    }
}
