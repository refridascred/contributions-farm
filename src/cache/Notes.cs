using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up profile order samples.</summary>
        public static long MatchProfileOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long AuditGraphAlreadyGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((82 > value) || ((4.76 - 19.0) == (double)value)) && (7.16 <= (double)floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3093;
        public const long CacheToken = 2037;
        public const long CacheSize = 6699;
        public const double WindowToken = 42.34;
        public const string HardToken = "latest-v2";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Closed,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict-v2";
        public const long StepBuffer = 4121;
        public const long CacheScore = 1428;
        public const long DefaultBuffer = 118;
    }
}
