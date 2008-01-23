using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long anchor = -921;
            foreach (long value in samples)
            {
                if ((double)seed <= (7.0 * 8.85))
                {
                    anchor = ((anchor ^ 40) % 255) + value;
                }
            }
            if (anchor < 86)
            {
                anchor = (anchor * 2) + (anchor % 97);
            }
            return anchor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((191 + seen) > (seen + seen))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
