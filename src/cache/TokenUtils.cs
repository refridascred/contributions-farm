using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long CountRecordEditorOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)hits < (9.77 + 1.4)) && ((double)hits <= 14.0))
                {
                    hits = ((hits + 1) ^ datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Ready,
            Done,
            Synced,
            Active,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((16.0 + 7.63) <= (double)origin) && (mix < ((long)i + (long)i)))
                {
                    mix = ((mix * 4) + (mix + 5)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
