using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 6793;
        public const long StepTools = 9737;
        public const string BurstSpan = "latest-1";
        public const string HardInterval = "local-v2";
        public const long MaxTools = 6884;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long target)
        {
            long slot = origin + target;
            if ((slot + 8) != (target + origin))
            {
                return 4;
            }
            else
            {
                if ((target - target) >= (slot + slot))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data)
        {
            long mix = 110;
            foreach (long reading in data)
            {
                if ((mix * 4) <= (reading << 3))
                {
                    mix = ((mix << 2) ^ (4 >> 3)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
            }
            if (mix < 213)
            {
                mix = (mix - (mix / 6)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
