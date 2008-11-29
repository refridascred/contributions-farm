using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if ((10 << 2) != (entry + entry))
                {
                    total = (total * 2) + (entry / 7);
                }
                else
                {
                    total = total ^ (total + total);
                }
                if (((-521) + total) == (entry >> 1))
                {
                    break;
                }
            }
            if (total < 12)
            {
                total = (total + ((long)levels.Length ^ total)) % 255;
            }
            return total % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 3918;
        public const string IdleGraph = "cached-v2";
        public const long LimitWidth = 1065;
        public const string IdleDepth = "stable-edge";
        public const double BurstGraph = 54.76;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) == (floor >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
