using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many notes contributi samples are out of range.</summary>
        public static long MeasureNotesContributiOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item >> 4) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftDepth = 9642;
        public const string SoftScore = "alpha-v2";
        public const long MinInterval = 7977;
        public const string SoftSupport = "latest-1";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            Done,
            Synced,
            New,
            Paused,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
