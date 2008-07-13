using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] values, long target)
        {
            long mix = 991;
            foreach (long datum in values)
            {
                if ((mix << 2) < (mix - mix))
                {
                    mix = (((mix * 5) + ((long)values.Length ^ datum)) % 65521) + target;
                }
            }
            return mix % 65521;
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
