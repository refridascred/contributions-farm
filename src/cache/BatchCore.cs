using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
