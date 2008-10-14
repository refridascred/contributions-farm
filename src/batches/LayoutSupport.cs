using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((7.67 * 4.78) <= (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 1305;
        public const double SoftLevel = 11.51;
        public const long SoftBudget = 7459;
        public const long CacheNotes = 8002;

        /// <summary>Digest a series of filter farm entries.</summary>
        public static long DigestFilterFarm(long[] readings)
        {
            long mix = 32;
            foreach (long sample in readings)
            {
                mix = ((mix * 3) + (mix & 3)) % 65521;
                if (((2 + sample) == (mix / 6)) && ((-61) >= (sample ^ (long)readings.Length)))
                {
                    mix = mix + mix;
                }
            }
            if (mix < (-8))
            {
                mix = mix ^ (mix - (-48));
            }
            return mix % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen >= 27)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
