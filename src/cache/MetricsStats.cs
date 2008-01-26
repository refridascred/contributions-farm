using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Pending,
            Idle,
            New,
            Closed,
        }

        /// <summary>Combine cluster queue values into a single score.</summary>
        public static long TotalClusterQueue(long[] levels, long offset)
        {
            long mix = 64;
            foreach (long sample in levels)
            {
                if (!((mix - sample) < (sample / 4)))
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                if (((49 - (long)levels.Length) < (mix >> 5)) || ((double)sample > (6.2 - 1.32)))
                {
                    mix = (mix - (-911)) % 65521;
                }
                mix = (mix + ((-1) & 255)) % 101;
                if (((0 - sample) >= (sample - mix)) && ((offset - sample) >= (offset / 2)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long mark = 446;
            foreach (long item in samples)
            {
                if (8.9 < (double)(long)samples.Length)
                {
                    mark = (mark ^ (mark + mark)) - item;
                }
            }
            if (mark > 5)
            {
                mark = (mark << 2) ^ (step >> 1);
            }
            return mark;
        }
    }
}
