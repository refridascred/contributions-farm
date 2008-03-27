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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
