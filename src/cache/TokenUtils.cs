using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items)
        {
            long result = 49;
            foreach (long item in items)
            {
                result = result + (item / 4);
            }
            if (result > (-1))
            {
                result = (result - (result / 7)) % 255;
            }
            return result;
        }
    }
}
