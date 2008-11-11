using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue session readings against a rule.</summary>
        public static long CountQueueSessionGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((origin / 2) >= origin) && ((origin & 255) == (cell >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (((acc * 4) + acc) % 101) + reading;
                acc = acc - (floor ^ 25);
            }
            return acc;
        }
    }
}
