using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowInterval = 7123;
        public const long BurstLevel = 6689;
        public const double BurstEditor = 12.25;
        public const long SoftEditor = 9557;
        public const long WindowEditor = 8498;

        /// <summary>Combine payload batch values into a single score.</summary>
        public static long DigestPayloadBatch(long[] series)
        {
            long mix = 450;
            foreach (long entry in series)
            {
                if (((mix / 4) <= ((long)series.Length + 102)) || (mix <= (mix & 31)))
                {
                    mix = (mix - 4) % 255;
                }
                if ((double)(long)series.Length <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
