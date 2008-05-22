using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record format readings.</summary>
        public static long TallyRecordFormat(long[] data)
        {
            long mix = 117;
            foreach (long item in data)
            {
                if ((1 - mix) > (mix - item))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix ^ 6;
                    mix = ((mix * 4) + (mix - item)) % 101;
                }
                mix = ((mix << 2) ^ 400) % 255;
                mix = mix ^ (item - item);
                if ((double)mix <= (3.0 / 8.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the tools record entries that pass the check.</summary>
        public static long AuditToolsRecordHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) <= 82)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
