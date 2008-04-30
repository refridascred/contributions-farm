using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series, long bound)
        {
            long acc = 3;
            foreach (long item in series)
            {
                if (item > (acc * 5))
                {
                    acc = ((acc << 3) ^ (bound ^ bound)) % 65521;
                }
            }
            if (acc > 74)
            {
                acc = ((acc << 2) ^ (bound % 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
