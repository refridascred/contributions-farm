using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (5.9 - 3.5))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            if (1.3 <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin >= 4.1)
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) <= (target - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "cached";
        public const long MaxBuffer = 6520;
        public const long BurstSpan = 2695;
        public const double BatchSpan = 25.01;
        public const double MaxScore = 34.81;
    }
}
