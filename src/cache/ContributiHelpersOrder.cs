using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= (4.4 + 9.01))
                {
                    matches = ((matches + 2) + sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if (origin < (delta & 127))
            {
                return 5;
            }
            else
            {
                if ((double)delta <= (0.29 / 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((((-42) >> 3) > (3 + origin2)) && ((delta & 7) <= origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
