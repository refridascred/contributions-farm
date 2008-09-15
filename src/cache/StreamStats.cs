using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
