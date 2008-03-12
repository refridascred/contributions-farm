using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                if ((datum % 100) != (datum - sum))
                {
                    sum = (sum ^ (datum + datum)) % 65521;
                }
                else
                {
                    sum = (sum - (91 + sum)) % 65521;
                }
            }
            if (sum < 45)
            {
                sum = (sum ^ (sum & 127)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Retry,
            Synced,
            Draft,
        }
    }
}
