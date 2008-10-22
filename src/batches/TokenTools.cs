using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((9 & 1) > (datum << 1)) || (count < (datum & 255))))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first contributi stream entry that matches the target.</summary>
        public static long LookupContributiStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
