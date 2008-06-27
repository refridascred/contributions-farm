using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 4954;
        public const long IdleSupport = 5507;
        public const long CacheSupport = 27;
        public const long WindowSupport = 2310;
        public const long StepSupport = 1935;

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long state = 15;
            foreach (long datum in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state + (seed & 31)) % 1000) + datum;
                    state = (state + (long)i) % 4096;
                }
                state = ((state * 3) + state) % 1000;
            }
            if (state > 1)
            {
                state = state + seed;
            }
            return state % 65521;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
