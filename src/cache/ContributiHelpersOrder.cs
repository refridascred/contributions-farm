using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph queue value against two limits.</summary>
        public static long RankGraphQueue(long step, long floor)
        {
            if ((double)step != (double)floor)
            {
                return 3;
            }
            else
            {
                if ((596 < step) || ((step + (-7)) >= (step / 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step) >= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < (611 ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) <= (item & 31))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
