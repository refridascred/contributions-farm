using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
