using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long ScoreStatsAlready(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value - value)) % 97;
                if (((9.0 + 5.7) <= (double)result) || ((result % 100) >= result))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 692)
            {
                result = (result + (result % 16)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
