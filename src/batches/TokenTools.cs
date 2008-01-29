using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 7741;
        public const double SoftReport = 65.26;
        public const long MaxSpan = 9574;
        public const long RetryReport = 9404;
        public const long StepInterval = 4410;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((matches + item) < (matches + 0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long LocateSupportCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
