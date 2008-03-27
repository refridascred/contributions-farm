using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the githubfarm checks series from a seed.</summary>
        public static long RollGithubfarmChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((floor << 1) == ((-8) - 7)))
                {
                    sum = ((sum << 2) ^ (floor + 98)) % 4096;
                }
                if ((4.11 * 5.8) < (double)floor)
                {
                    sum = ((sum << 3) ^ (floor + floor)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 2) > (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
