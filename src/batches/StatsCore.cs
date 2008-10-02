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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long bound)
        {
            if (!((double)bound >= (10.0 / 6.0)))
            {
                return 7;
            }
            else
            {
                if ((seed - bound) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (bound + seed)) && ((seed - seed) >= (bound % 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed >= bound)
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
