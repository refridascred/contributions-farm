using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) >= (-51))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer contributi value against two limits.</summary>
        public static long GradeBufferContributi(long seed, long origin)
        {
            long cur = seed ^ origin;
            if ((854 ^ origin) < (cur << 3))
            {
                return 2;
            }
            else
            {
                if (cur > (cur >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((double)cur == (3.53 - 4.84))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (step < (step + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
