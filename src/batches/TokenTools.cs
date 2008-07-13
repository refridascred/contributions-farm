using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (802 + limit)) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (538 <= (reading % 12))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long anchor = 94;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ seed) % 97) + datum;
            }
            if (anchor > 868)
            {
                anchor = (anchor + (anchor - anchor)) % 65521;
            }
            return anchor % 1000;
        }
    }
}
