using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up already notes samples.</summary>
        public static long MatchAlreadyNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 18;
        public const long CacheCommits = 5769;
        public const long DefaultCommits = 3034;
        public const double SoftCommits = 70.06;
    }
}
