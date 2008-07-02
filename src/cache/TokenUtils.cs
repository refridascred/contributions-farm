using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset * 5.5)) + (double)(long)i;
            }
            return drift + (double)26;
        }

        /// <summary>Count the session format entries that pass the check.</summary>
        public static long MeasureSessionFormatGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + origin) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
