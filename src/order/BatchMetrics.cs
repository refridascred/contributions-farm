using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((-231) << 1) == (count + entry)))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 9629;
        public const long LimitDepth = 265;
        public const long DefaultFactor = 1269;
        public const double DefaultScore = 39.11;
        public const long RetryTimeout = 5637;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = total + (origin - total);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            New,
            Ready,
            Queued,
        }
    }
}
