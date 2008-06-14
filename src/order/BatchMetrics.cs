using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item < (item + item)) || (item <= (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Synced,
            Draft,
            Active,
            Done,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((302 * 4) < step))
                {
                    mix = (mix + (mix * 2)) % 1000;
                }
                mix = ((mix * 3) + (mix & 1)) % 4096;
                if ((mix > 85) && ((60 - mix) != (step ^ mix)))
                {
                    mix = (mix << 2) ^ 262;
                    break;
                }
                else
                {
                    mix = mix + ((long)i + step);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSize = 800;
        public const long IdleInterval = 2709;
        public const double StepAlready = 15.8;
        public const double HardDepth = 1.55;
        public const long BaseLevel = 2156;

        /// <summary>Validate cache support readings against a bound.</summary>
        public static bool CheckCacheSupportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
