using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long TotalCounterTools(long[] items)
        {
            long total = 25;
            foreach (long sample in items)
            {
                total = (total ^ (sample + 3)) % 65521;
                total = ((total * 5) + (sample ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Failed,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5070;
        public const long MaxCommits = 1416;
        public const long WindowCommits = 9862;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Active,
            Failed,
            Done,
        }
    }
}
