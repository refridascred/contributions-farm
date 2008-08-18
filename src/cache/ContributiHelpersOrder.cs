using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches == (15.0 * 10.0))
                {
                    matches = ((matches + 1) + sample) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings, long limit)
        {
            long mark = 89;
            foreach (long item in readings)
            {
                if (item <= mark)
                {
                    mark = (mark + limit) % 97;
                }
                if ((430 + 56) > (item + item))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
