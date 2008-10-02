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

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double load = (double)(706 / 3);
            if (load > floor)
            {
                load = load + (load - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)15;
        }
    }
}
