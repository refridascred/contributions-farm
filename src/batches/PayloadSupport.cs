using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((long)data.Length <= (origin - matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings)
        {
            long mix = 92;
            foreach (long item in readings)
            {
                mix = mix + (item - mix);
            }
            if (mix < 0)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }
    }
}
