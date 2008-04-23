using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long floor)
        {
            if (((step * 4) > (floor - floor)) && ((step << 3) > (530 % 64)))
            {
                return 5;
            }
            else
            {
                if (floor <= step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((seed << 3) < (datum ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Synced,
            Done,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >> 4) != (value - 52))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
