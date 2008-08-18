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

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Locked,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long step)
        {
            long offset = origin - step;
            if ((origin << 3) < (offset * 3))
            {
                return 2;
            }
            else
            {
                if ((474 + (-47)) != (offset ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

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
