using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstWidth = 28.6;
        public const long RetryBatch = 7392;
        public const double SoftBatch = 30.82;
        public const string IdleScore = "latest-v2";
        public const long IdleBatch = 584;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 54;
        public const double MaxSize = 68.66;
        public const long SoftRatio = 3382;
        public const double DefaultFactor = 14.64;
    }
}
