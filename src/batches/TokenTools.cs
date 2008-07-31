using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long origin)
        {
            long anchor = 324;
            foreach (long entry in items)
            {
                if (((anchor >> 5) < (anchor + origin)) && (origin < 14))
                {
                    anchor = (anchor * 4) + (entry / 7);
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - (origin & 7);
            }
            return anchor % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5837;
        public const long RetryScore = 6837;
        public const long BatchInterval = 8609;
        public const long RetryToken = 7306;

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (((result << 3) ^ result) % 101) + item;
            }
            return result % 1000;
        }
    }
}
