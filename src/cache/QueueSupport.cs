using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BatchCount = "cached";
        public const long IdleWindow = 9060;
        public const string MinWindow = "alpha-1";
        public const long BurstFactor = 4854;
        public const long StepInterval = 1543;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 6682;
        public const long BatchSchema = 9967;
        public const long BaseSchema = 7689;
        public const long HardBudget = 8611;

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long mix = 76;
            foreach (long entry in samples)
            {
                mix = ((mix + (mix + limit)) % 97) ^ entry;
            }
            if (mix < 24)
            {
                mix = (mix + (limit - limit)) % 255;
            }
            return mix;
        }
    }
}
