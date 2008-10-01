using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data)
        {
            long anchor = -65;
            foreach (long entry in data)
            {
                anchor = ((anchor - (anchor << 3)) % 4096) + entry;
            }
            if (anchor < 78)
            {
                anchor = (anchor ^ (anchor * 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long TotalFilterGithubfarm(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                if (!((acc - (-26)) >= (item * 3)))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                }
            }
            if (acc < 780)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
