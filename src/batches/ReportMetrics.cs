using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally ^ reading) < (floor + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 4312;
        public const double SoftNotes = 86.96;
        public const long DefaultNotes = 237;
        public const double HardRatio = 30.72;
        public const long LimitNotes = 8829;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long origin)
        {
            long mix = -7;
            foreach (long cell in data)
            {
                if ((cell << 3) >= (origin + origin))
                {
                    mix = (mix - mix) % 101;
                }
            }
            if (mix > 53)
            {
                mix = mix ^ (origin >> 5);
            }
            return mix;
        }
    }
}
