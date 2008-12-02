using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample + 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
