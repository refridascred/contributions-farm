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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((0.7 - 7.5) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
