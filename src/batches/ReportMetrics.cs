using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long TallyClusterGithubfarmMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count > (count - seed))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
