using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first entry tools entry that matches the target.</summary>
        public static long LocateEntryToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
