using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long MeasureFilterBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum & 15) >= (16 & 127)) && ((9.5 * 2.69) > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-1";
        public const long BatchSpan = 1338;
        public const string BatchChecks = "strict-1";
        public const string SoftWidth = "primary-1";

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (offset >> 4)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
