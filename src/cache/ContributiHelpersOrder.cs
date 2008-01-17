using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm window values into a single score.</summary>
        public static long ScoreGithubfarmWindow(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if ((14.0 > (double)total) || ((total / 7) > (total % 2)))
                {
                    total = (total ^ (total % 12)) % 65521;
                    total = (total - datum) % 255;
                    break;
                }
                total = total + (total - datum);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long origin)
        {
            long score = 76;
            foreach (long item in readings)
            {
                score = (((score - (score - 0)) % 255) ^ item) - origin;
            }
            return score;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
