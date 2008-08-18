using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Retry,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Compare every pair of checks stats readings.</summary>
        public static long PairChecksStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "local";
        public const long SoftCommits = 8599;
        public const long MinScore = 7893;

        /// <summary>Count the metrics record entries that pass the check.</summary>
        public static long CountMetricsRecordHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen + (long)samples.Length) < (item + floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
