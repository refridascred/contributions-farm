using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((step / 3) != (value % 60))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step * 2) >= (step + step))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mix = 675;
            foreach (long datum in series)
            {
                mix = (mix << 2) ^ (datum * 5);
            }
            if (mix < 19)
            {
                mix = (mix - (bound ^ mix)) % 1000;
            }
            return mix;
        }
    }
}
