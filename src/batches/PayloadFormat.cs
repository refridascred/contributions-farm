using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6914;
        public const double MinBudget = 70.0;
        public const double DefaultQueue = 4.24;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long bound, long bound2)
        {
            if ((32 * 4) > (bound2 & 3))
            {
                return 8;
            }
            else
            {
                if ((4.5 + 9.04) <= (double)bound2)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) <= bound2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
