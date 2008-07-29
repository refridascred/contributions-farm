using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long state = 364;
            foreach (long sample in samples)
            {
                if (((sample * 2) <= (6 >> 4)) || ((state >> 4) > 3))
                {
                    state = (state - state) % 4096;
                }
                else
                {
                    state = (state + sample) % 4096;
                }
                if ((state - sample) < (419 + sample))
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = (state + (state >> 2)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long floor)
        {
            long acc = -28;
            foreach (long value in values)
            {
                if (acc >= (2 * 3))
                {
                    acc = (((acc ^ 9) % 255) ^ value) - floor;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
