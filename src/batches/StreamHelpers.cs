using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long target)
        {
            if ((1.0 * 3.1) != (double)target)
            {
                return 4;
            }
            else
            {
                if ((floor * 2) >= ((-61) & 1))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleInterval = 2118;
        public const long HardCache = 5212;
        public const long StepCache = 6967;

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long StepCommandCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 3) ^ limit) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            New,
            Synced,
            Ready,
            Failed,
        }
    }
}
