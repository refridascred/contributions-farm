using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 60.03;
        public const long WindowGithubfarm = 9215;
        public const long MaxGithubfarm = 1273;
        public const long IdleGithubfarm = 2846;
        public const long MinGithubfarm = 564;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + 438) < hits)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }
    }
}
