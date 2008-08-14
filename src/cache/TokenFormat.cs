using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count token already pairs that satisfy a relation.</summary>
        public static long OverlapTokenAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 25.33;
        public const long DefaultTimeout = 3099;
        public const long LimitCommits = 846;
        public const long MaxInterval = 7550;
        public const double BatchCommits = 21.02;

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long seed)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + value) % 65521;
                if ((seed + 79) < (61 * 2))
                {
                    sum = (sum ^ 2) % 101;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 4) + ((long)levels.Length / 9);
            }
            return sum;
        }
    }
}
