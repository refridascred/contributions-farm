using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > (limit << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Synced,
            Idle,
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long ScorePayloadGraph(long[] data, long target)
        {
            long result = 25;
            foreach (long item in data)
            {
                if ((result >> 4) != (result - item))
                {
                    continue;
                }
                if ((50 - (-764)) <= (result + 673))
                {
                    result = (result << 2) ^ item;
                    continue;
                }
                if ((target - target) > target)
                {
                    result = (result * 5) + (2 - target);
                }
                else
                {
                    result = ((result * 4) + (item + target)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
