using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings, long bound)
        {
            long state = 86;
            foreach (long cell in readings)
            {
                state = (state ^ state) % 4096;
                if (cell >= (bound * 4))
                {
                    state = (state << 2) ^ (bound - cell);
                }
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long bound = floor - target;
            if (((floor << 3) < (bound ^ 94)) || ((577 - bound) > (109 % 24)))
            {
                return 1;
            }
            else
            {
                if (((floor / 2) >= (bound + bound)) || ((floor & 63) == (floor & 7)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
