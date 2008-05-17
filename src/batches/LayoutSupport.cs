using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long CompareChannelContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) < ((-5) * 3))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 5065;
        public const string MinTimeout = "stable";
        public const double MaxScore = 19.95;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample <= (16.0 + 9.64)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
