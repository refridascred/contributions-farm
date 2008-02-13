using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session notes readings against a rule.</summary>
        public static long TallySessionNotesMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (9.2 / 6.0))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinSize = "cached-1";
        public const long BurstAccount = 6551;
        public const string CacheRatio = "standard";
        public const string BatchCount = "strict-v2";
        public const string LimitAccount = "stable-1";

        /// <summary>Find the first filter farm entry that matches the target.</summary>
        public static long SeekFilterFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
