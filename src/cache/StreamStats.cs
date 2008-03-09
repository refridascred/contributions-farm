using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long mark = 56;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (sample + bound);
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long origin)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if (!((1.32 + 1.75) < (double)mix))
                {
                    mix = ((mix * 2) + (sample << 1)) % 1000;
                }
                mix = (mix * 2) + (origin >> 4);
            }
            if (mix > 7)
            {
                mix = (mix * 4) + (mix + 575);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 77.92;
        public const double WindowWidth = 48.46;
        public const string SoftCounter = "standard-v2";

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Stale,
        }
    }
}
