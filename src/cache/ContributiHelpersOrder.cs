using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length >= (250 * 5))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate payload metrics readings against a bound.</summary>
        public static bool VerifyPayloadMetricsBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
