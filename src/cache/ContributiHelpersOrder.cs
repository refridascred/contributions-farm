using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            if ((2.0 + 2.07) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (origin >= (seed / 9))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine payload account values into a single score.</summary>
        public static long FoldPayloadAccount(long[] readings, long offset)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                state = (((state ^ (193 >> 4)) % 65521) ^ entry) - offset;
            }
            return state;
        }

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool VerifyCommitsFormatBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
