using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 16) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter githubfarm entry that matches the target.</summary>
        public static long LocateFilterGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = (acc * 5) + 7;
                acc = (acc << 2) ^ (entry / 6);
                acc = acc ^ ((-904) - 569);
            }
            if (acc > (-427))
            {
                acc = (acc << 3) ^ (floor ^ acc);
            }
            return acc;
        }
    }
}
