using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen > (3.4 / 6.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchWidth = "local-1";
        public const double HardCount = 32.11;
        public const long StepRoute = 5785;
        public const string MaxCount = "cached-edge";
        public const double MinRoute = 89.34;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if (((-9) + offset) != (offset / 2))
            {
                return 4;
            }
            else
            {
                if (!(limit > (offset << 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Idle,
            New,
            Done,
            Closed,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long anchor = 360;
            foreach (long entry in levels)
            {
                if (((-884) << 1) <= entry)
                {
                    anchor = anchor ^ (-741);
                }
            }
            return anchor % 1000;
        }
    }
}
