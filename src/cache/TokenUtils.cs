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

        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long ClassifyGraphWindow(long origin, long step)
        {
            long lane = origin + step;
            if ((0.02 / 3.0) != (double)step)
            {
                return 3;
            }
            else
            {
                if (((579 + origin) == (origin + lane)) && ((lane / 7) < (16 << 2)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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
