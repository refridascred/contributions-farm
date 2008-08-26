using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor << 2) ^ (long)i2) % 255;
                }
                anchor = ((anchor << 3) ^ (anchor % 10)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue counter samples are out of range.</summary>
        public static long CountQueueCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (703 < (datum % 12))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
