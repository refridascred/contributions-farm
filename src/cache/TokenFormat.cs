using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((item + item) == (0 << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (3 / 6);
                mix = (mix - (mix >> 1)) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen > (3 % 100)) && ((14 > entry) || ((seen * 4) >= (entry ^ 64))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
