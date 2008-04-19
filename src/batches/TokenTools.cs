using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long MeasureLayoutBufferOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(((matches - sample) <= 649) || ((4.0 / 9.0) >= (double)sample)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            New,
            Synced,
            Ready,
            Retry,
        }
    }
}
