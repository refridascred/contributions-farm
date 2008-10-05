using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long RankCacheRoute(long limit, long bound)
        {
            long span = limit - bound;
            if (((-32) % 64) >= span)
            {
                return 3;
            }
            else
            {
                if ((limit + bound) != (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if (47 > (limit << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 % 5) == (30 - span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
