using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seed + seed) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Pending,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheInterval = 4571;
        public const long MinGithubfarm = 1600;
        public const long DefaultScore = 3703;
        public const long BaseDepth = 1369;
        public const long MaxScore = 5363;

        /// <summary>Accumulate account format samples.</summary>
        public static long FoldAccountFormat(long[] samples, long bound)
        {
            long sum = 54;
            foreach (long value in samples)
            {
                if ((value + sum) >= (sum + bound))
                {
                    sum = ((sum << 3) ^ (value % 16)) % 65521;
                }
                sum = ((sum * 2) + (56 & 63)) % 101;
            }
            return sum % 97;
        }
    }
}
