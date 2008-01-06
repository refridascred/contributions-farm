using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 39.37;
        public const string IdleBatch = "staging";
        public const long StepFactor = 6267;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Synced,
            Stale,
            New,
        }

        /// <summary>Fold a list of stream tools readings.</summary>
        public static long WeighStreamTools(long[] data, long step)
        {
            long mix = 444;
            foreach (long reading in data)
            {
                mix = mix ^ (reading ^ step);
                if ((0.46 / 9.0) >= (double)step)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
