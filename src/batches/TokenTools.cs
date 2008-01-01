using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 908;
            foreach (long datum in series)
            {
                mix = (((mix * 3) + mix) % 4096) ^ datum;
            }
            if (mix < 31)
            {
                mix = (mix * 3) + (mix - 6);
            }
            return mix;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)hits == (double)7) && (hits > (cell + cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
