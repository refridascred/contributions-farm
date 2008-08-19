using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up window cache samples.</summary>
        public static long OverlapWindowCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (reading & 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
