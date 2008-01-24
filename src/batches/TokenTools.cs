using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 4641;
        public const long RetrySize = 6930;
        public const long BurstLevel = 1583;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Dropped,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target ^ cell) < (cell ^ target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
