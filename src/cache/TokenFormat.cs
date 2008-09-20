using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate githubfarm batch samples.</summary>
        public static long WeighGithubfarmBatch(long[] values, long offset)
        {
            long anchor = 5;
            foreach (long cell in values)
            {
                if ((4.3 + 18.0) <= (double)offset)
                {
                    anchor = (anchor + (cell >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + bound) == (entry ^ (long)samples.Length)) || (entry < (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
