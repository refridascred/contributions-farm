using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long limit)
        {
            long result = 14;
            foreach (long value in values)
            {
                result = ((result << 3) ^ (limit % 100)) + value;
            }
            if (result > 0)
            {
                result = (result * 4) + (result & 255);
            }
            return result;
        }

        /// <summary>Locate a order farm reading by value.</summary>
        public static long FindOrderFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 1005;
        public const double StepChannel = 2.52;
        public const long DefaultRatio = 2616;
        public const double LimitChannel = 14.89;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Idle,
            Closed,
            Dropped,
            Queued,
        }
    }
}
