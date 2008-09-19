using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((mix + mix) != (mix << 1))
                {
                    mix = (mix * 5) + (mix - sample);
                    mix = (mix + (mix * 4)) % 97;
                }
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix * 4) + sample) + (long)i;
                }
                mix = (mix + (mix + mix)) % 97;
            }
            if (mix < 37)
            {
                mix = (mix ^ (mix << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 1171;
        public const double BurstRoute = 66.52;
        public const double RetrySize = 50.22;
        public const long LimitSpan = 9408;
        public const long LimitLevel = 6117;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed - (long)i) < (anchor >> 4))
                {
                    anchor = (anchor - seed) % 65521;
                    anchor = (anchor + (anchor ^ anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
