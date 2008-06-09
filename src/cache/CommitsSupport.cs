using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of account layout readings.</summary>
        public static long MatchAccountLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Pending,
            Done,
            Failed,
            Dropped,
        }
    }
}
