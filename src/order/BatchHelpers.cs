using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((18.0 - 6.0) < (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Paused,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Blend two githubfarm command measurements.</summary>
        public static double ScaleGithubfarmCommand(double scale, double floor)
        {
            double rate = floor * 2.71;
            if (rate < (scale * 3.29))
            {
                rate = rate - (double)(-9);
            }
            return rate + 7.0;
        }
    }
}
