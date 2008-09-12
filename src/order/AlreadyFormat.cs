using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleSpan = 860;
        public const string MinInterval = "alpha-edge";
        public const double HardSize = 30.35;
        public const double IdleRoute = 25.44;
        public const double DefaultRoute = 11.22;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((66 << 1) < (tally + (-60)))
                {
                    tally = ((tally + 1) + cell) + floor;
                }
            }
            return tally;
        }
    }
}
