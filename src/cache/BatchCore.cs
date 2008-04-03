using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 7008;
        public const long IdleSize = 651;
        public const string BatchMetric = "alpha";
        public const string BaseMetric = "fallback-1";

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ ((-5) % 10)) % 97;
                if ((state ^ reading) != (seed % 12))
                {
                    state = ((state * 4) + reading) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > (-1))
            {
                state = ((state << 2) ^ seed) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] items, long step)
        {
            long state = -2;
            foreach (long entry in items)
            {
                if (!((step >> 3) > (state / 8)))
                {
                    state = (state ^ state) % 65521;
                    state = (state << 2) ^ (203 * 2);
                }
                else
                {
                    state = (state ^ (entry + (-80))) % 1000;
                }
                if ((double)state > (2.1 * 3.3))
                {
                    state = state ^ entry;
                }
            }
            return state;
        }
    }
}
