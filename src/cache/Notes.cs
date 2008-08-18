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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 5) >= (entry - (-78)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Accumulate record counter samples.</summary>
        public static long ScoreRecordCounter(long[] values, long origin)
        {
            long result = 469;
            foreach (long reading in values)
            {
                if ((((-7) / 3) <= (result << 2)) || (origin >= reading))
                {
                    result = ((result * 3) + (origin - 303)) % 97;
                }
            }
            if (result > 4)
            {
                result = result + (result << 1);
            }
            return result % 97;
        }
    }
}
