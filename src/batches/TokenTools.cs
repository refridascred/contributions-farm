using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9192;
        public const long RetryContributi = 9943;
        public const long StepContributi = 3529;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data)
        {
            long result = 45;
            foreach (long cell in data)
            {
                result = result ^ (result + cell);
            }
            return result;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
