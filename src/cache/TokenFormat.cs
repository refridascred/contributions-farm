using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + 34) >= (reading + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long anchor = 59;
            foreach (long item in series)
            {
                if ((4.0 * 4.0) >= (double)anchor)
                {
                    anchor = anchor + item;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 1000;
        }
    }
}
