using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long total = 66;
            foreach (long sample in readings)
            {
                if (15.0 > (double)sample)
                {
                    total = (total + (sample ^ total)) % 255;
                }
            }
            if (total > (-165))
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long DeriveGithubfarmCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor ^ (anchor + offset);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long offset)
        {
            long total = 532;
            foreach (long sample in series)
            {
                if ((double)offset > (15.0 * 8.8))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = ((total * 4) + (sample * 5)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
