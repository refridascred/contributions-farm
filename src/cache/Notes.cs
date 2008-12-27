using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool GuardRouteStatsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double scale, double offset)
        {
            double mean = offset * 0.4;
            return (mean + (offset / 4.0)) + scale;
        }

        /// <summary>Derive the next record channel value from a seed.</summary>
        public static long StepRecordChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1380;
        public const long BatchLayout = 9954;
        public const string MinLayout = "fallback-edge";
        public const long IdleLayout = 1557;
        public const string BurstBudget = "strict-v2";
    }
}
