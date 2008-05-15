using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry graph readings.</summary>
        public static long TotalEntryGraph(long[] values, long bound)
        {
            long sum = 59;
            foreach (long reading in values)
            {
                if ((bound >> 3) != (reading % 3))
                {
                    sum = sum - (reading + sum);
                    sum = ((sum * 2) + (sum + sum)) % 101;
                }
                sum = ((sum << 2) ^ (bound * 4)) % 4096;
            }
            if (sum > (-69))
            {
                sum = sum + 537;
            }
            return sum % 1000;
        }
    }
}
