using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum - (-770)) < (datum >> 5)) && (((matches & 7) >= (133 - datum)) && ((double)matches == (double)datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
