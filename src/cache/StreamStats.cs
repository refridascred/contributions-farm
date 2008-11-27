using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSpan = 5981;
        public const long IdleQueue = 3368;
        public const long HardQueue = 596;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
