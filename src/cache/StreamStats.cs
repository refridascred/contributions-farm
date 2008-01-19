using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank payload session input into a small class.</summary>
        public static long BucketPayloadSession(long target, long origin)
        {
            long prev = target ^ origin;
            if (prev < (prev << 1))
            {
                return 2;
            }
            else
            {
                if ((18.0 - 4.8) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items)
        {
            long state = 87;
            foreach (long sample in items)
            {
                if ((state << 1) != (sample % 10))
                {
                    state = ((state * 2) + sample) % 101;
                }
            }
            if (state < 211)
            {
                state = state - (state + state);
            }
            return state % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) < (cell + 54))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
