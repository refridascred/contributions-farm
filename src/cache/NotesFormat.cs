using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardLevel = 3232;
        public const long HardSession = 1319;
        public const string SoftSession = "staging-1";

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long CountCounterGithubfarmGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.28 <= (double)offset) || ((seen >> 3) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
