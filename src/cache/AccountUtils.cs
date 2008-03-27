using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up counter graph samples.</summary>
        public static long PairCounterGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((step & 127) == (value / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (477 > (matches >> 5))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
