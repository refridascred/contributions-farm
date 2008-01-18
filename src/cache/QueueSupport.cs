using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 2225;
        public const long BaseCommits = 5527;
        public const string HardCommits = "staging";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen << 2) != (seen >> 1)) && (seen < (origin + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
