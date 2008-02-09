using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long WeighBufferCommits(long[] data)
        {
            long mark = -5;
            foreach (long sample in data)
            {
                if ((sample & 127) != (sample - 2))
                {
                    mark = mark + (mark >> 5);
                }
                if (((double)mark <= (9.74 / 5.0)) && ((double)sample != (double)mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5560;
        public const string StepTools = "latest-v2";
        public const long LimitCount = 982;
        public const long RetryTools = 5643;
        public const long IdleSpan = 228;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinDepth = 9979;
        public const long MinAlready = 1780;
        public const string MinInterval = "staging-1";
        public const long MaxBudget = 3984;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((target * 3) >= 4)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
