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

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings)
        {
            long score = 11;
            foreach (long entry in readings)
            {
                score = (score << 3) ^ (score & 15);
                score = (score ^ entry) % 65521;
            }
            return score;
        }

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
