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

        /// <summary>Iterate the counter buffer series from a seed.</summary>
        public static long DeriveCounterBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark + (mark + (long)i)) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
