using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Done,
            Ready,
            Closed,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 8504;
        public const long SoftChannel = 2285;
        public const string MaxLevel = "fallback";
        public const long BurstChannel = 8188;
    }
}
