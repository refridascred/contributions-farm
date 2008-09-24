using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster entry readings.</summary>
        public static long ScoreClusterEntry(long[] samples)
        {
            long result = 934;
            foreach (long datum in samples)
            {
                result = ((result * 5) + datum) % 101;
            }
            return result;
        }

        /// <summary>Check that every cache githubfarm entry stays within the limit.</summary>
        public static bool ValidateCacheGithubfarmRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
