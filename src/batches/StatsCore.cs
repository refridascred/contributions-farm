using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long bound, long origin)
        {
            if (bound <= origin)
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) != (627 & 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-edge";
        public const string IdleDepth = "legacy-v2";
        public const double BaseScore = 45.59;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3989;
        public const double BurstBudget = 6.73;
        public const long BatchCache = 352;
        public const long StepSize = 1958;
        public const long SoftCache = 2988;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
