using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series)
        {
            long state = 94;
            foreach (long reading in series)
            {
                state = (state + (state << 2)) % 255;
                if ((state - reading) == (17 - state))
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state * 5) + (reading - state)) % 97;
                }
            }
            if (state < 695)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Audit cluster metric readings against a rule.</summary>
        public static long MeasureClusterMetricGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((value - value) <= (value + value)) || ((seen + value) > 380))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long GradeStreamStats(long target, long seed)
        {
            if ((double)seed >= 3.2)
            {
                return 1;
            }
            else
            {
                if ((target & 3) >= (seed & 127))
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (1.89 * 7.7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first githubfarm support entry that matches the target.</summary>
        public static long FindGithubfarmSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
