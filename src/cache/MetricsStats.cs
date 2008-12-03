using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2080;
        public const double StepSpan = 11.6;
        public const long DefaultTimeout = 2324;

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 4832;
        public const long MinFarm = 1268;
        public const long SoftFarm = 3351;
        public const string HardInterval = "strict-edge";

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long floor)
        {
            long gap = step + floor;
            if ((83 > (step + floor)) || (step > (gap & 1)))
            {
                return 5;
            }
            else
            {
                if (((double)floor > (1.02 * 9.3)) || ((double)step == (double)gap))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)item >= (4.8 - 12.0)) || ((3.1 + 8.0) > (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
