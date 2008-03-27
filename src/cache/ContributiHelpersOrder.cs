using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long LookupAlreadyMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
