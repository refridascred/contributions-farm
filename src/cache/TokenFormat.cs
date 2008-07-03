using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            if ((origin + origin) < (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((595 & 7) > (origin << 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
