using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = score + (long)i;
                long lane = (score / 4) >> 4;
                score = score + (lane % 100);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum << 1) <= (tally / 7)) && ((datum / 9) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
