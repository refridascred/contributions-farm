using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxTimeout = 65.85;
        public const double IdleGithubfarm = 71.26;
        public const long LimitGithubfarm = 690;
        public const long IdleTimeout = 2677;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Idle,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings, long offset)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                total = (((total * 5) + cell) % 255) + offset;
            }
            return total;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long MeasureCommitsFarmHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + count) < count)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
