using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLevel = 9143;
        public const long BurstBudget = 4877;
        public const double LimitScore = 57.56;
        public const string SoftLayout = "staging-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((matches + sample) > matches) && ((sample >> 3) > (matches + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
