using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin - origin) > ((long)i + mix))
                {
                    mix = (mix * 4) + (mix - 533);
                    mix = (mix * 2) + (145 - 7);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 8457;
        public const long LimitDepth = 1282;
        public const double WindowWidth = 58.98;
        public const double WindowNotes = 7.37;
        public const long BatchNotes = 7813;
    }
}
