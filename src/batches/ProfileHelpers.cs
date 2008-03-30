using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long bound)
        {
            long edge = target - bound;
            if ((double)bound < (7.1 * 1.0))
            {
                return 2;
            }
            else
            {
                if ((target * 3) > edge)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = -499;
            foreach (long sample in data)
            {
                mix = ((mix + mix) % 4096) ^ sample;
            }
            return mix;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                double bias = (double)origin + (double)21;
                if ((7.0 + 3.79) > (bias - bias))
                {
                    state = state - 723;
                    state = (state << 2) ^ ((long)i << 1);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
