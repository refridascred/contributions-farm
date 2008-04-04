using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((945 - acc) != (step - acc))
                {
                    acc = (acc ^ (acc - step)) % 97;
                    acc = (acc + (-31)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (ratio - rate);
        }
    }
}
