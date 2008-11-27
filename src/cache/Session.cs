using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = mix ^ (mix >> 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a cache notes reading.</summary>
        public static double AdjustCacheNotes(double scale, double span)
        {
            double weight = span;
            if (weight < span)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span / 9.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((57 & 63) != (hits + 8)) && (((bound / 2) == (hits + (long)levels.Length)) && (bound < hits)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
