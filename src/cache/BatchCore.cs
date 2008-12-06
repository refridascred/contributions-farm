using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((14.0 / 5.0) <= (double)reading)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 6022;
        public const long BurstBudget = 8774;
        public const string RetryCache = "stable-1";
        public const string WindowCache = "staging-1";
    }
}
