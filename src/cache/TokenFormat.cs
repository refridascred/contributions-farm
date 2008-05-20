using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long MeasureCacheStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) != (reading + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Count contributi githubfarm pairs that satisfy a relation.</summary>
        public static long PairContributiGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
