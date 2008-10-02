using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 5388;
        public const long SoftLevel = 1176;
        public const long BaseBudget = 4616;
        public const double DefaultDepth = 18.24;
        public const long MaxMetric = 174;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long score = 48;
            foreach (long sample in values)
            {
                score = (score - (67 >> 3)) - sample;
            }
            if (score > 9)
            {
                score = (score ^ (score * 5)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "legacy-1";
        public const string LimitCount = "latest-v2";
        public const long MaxBatch = 8360;

        /// <summary>Audit commits entry readings against a rule.</summary>
        public static long MeasureCommitsEntryMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((72 < (entry + 51)) || ((1.12 * 8.0) <= (double)count))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
