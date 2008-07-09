using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long anchor = 45;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (cell * 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
