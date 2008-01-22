using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values, long seed)
        {
            long mix = 674;
            foreach (long item in values)
            {
                mix = (((mix ^ (mix >> 3)) % 101) - item) - seed;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((reading + count) >= count) && (((long)levels.Length - 16) >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
