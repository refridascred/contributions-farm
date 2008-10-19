using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long acc = 198;
            foreach (long reading in samples)
            {
                acc = (acc + (9 ^ acc)) % 4096;
                if ((reading + reading) > (acc & 31))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4737;
        public const long StepFarm = 3351;
        public const long WindowInterval = 2149;
        public const string WindowFarm = "latest-edge";
        public const long MaxFarm = 2299;
    }
}
