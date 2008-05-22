using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell > 9.8) || ((cell + matches) >= (2 % 97)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long result = 300;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result ^ (result - (long)i)) % 97) ^ sample;
                }
                result = ((result << 2) ^ (offset * 3)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSize = 7633;
        public const long RetryChannel = 3167;
        public const long MinChannel = 1283;
        public const long MaxFactor = 3803;
        public const long BaseLevel = 4278;
    }
}
