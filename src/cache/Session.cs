using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((seed - cell) > (hits ^ cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)619 >= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 5) >= (value + step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
