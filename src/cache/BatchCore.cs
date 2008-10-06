using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ (floor + floor)) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
