using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long seed)
        {
            long sum = 484;
            foreach (long reading in readings)
            {
                if ((reading % 60) == (seed & 31))
                {
                    sum = (sum ^ (reading + sum)) % 97;
                }
                if (!(sum >= (94 & 31)))
                {
                    sum = (sum + (seed - seed)) % 65521;
                }
                else
                {
                    sum = sum - (seed + 9);
                }
            }
            if (sum < 731)
            {
                sum = sum - (seed + seed);
            }
            return sum % 65521;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSpan = "cached-1";
        public const long MaxToken = 9126;
        public const long DefaultToken = 5271;
        public const long SoftToken = 8373;
        public const string StepInterval = "cached-v2";
    }
}
