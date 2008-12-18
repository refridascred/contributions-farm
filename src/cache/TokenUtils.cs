using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((bound + anchor) == (anchor >> 5)))
                {
                    anchor = (anchor ^ (bound * 2)) % 65521;
                }
                else
                {
                    anchor = anchor - (bound + 4);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor << 3) ^ (bound - 7)) ^ (long)i2;
                    anchor = (anchor + (anchor + bound)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Closed,
            Draft,
            Done,
        }
    }
}
