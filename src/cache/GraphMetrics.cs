using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 4930;
        public const long BaseFormat = 5439;
        public const long LimitBudget = 7320;
        public const double StepFormat = 21.37;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long step)
        {
            long score = 826;
            foreach (long reading in items)
            {
                if ((14.0 * 19.0) <= (double)reading)
                {
                    score = (score << 3) ^ (233 ^ step);
                }
                else
                {
                    score = (score ^ (75 % 64)) % 101;
                }
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultLevel = 5260;
        public const long IdleFilter = 671;
        public const double BaseInterval = 22.51;
        public const double StepRatio = 60.79;
        public const double StepFilter = 54.09;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((6.14 + 0.2) > (double)entry) || !((entry + entry) < (entry + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
