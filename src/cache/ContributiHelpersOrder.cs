using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long score = 490;
            foreach (long datum in values)
            {
                if ((datum + origin) > (858 * 5))
                {
                    score = score - (45 ^ 7);
                }
                else
                {
                    score = (score - (origin / 6)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                acc = (acc << 3) ^ (acc + item);
            }
            return acc;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
