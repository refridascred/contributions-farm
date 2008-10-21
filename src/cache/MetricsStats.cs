using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long result = 515;
            foreach (long datum in data)
            {
                if (((0 - datum) > result) && ((result + datum) >= 599))
                {
                    result = result + 158;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - step) <= sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster stream sample.</summary>
        public static long LocateClusterStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every command cluster entry stays within the limit.</summary>
        public static bool GuardCommandClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
