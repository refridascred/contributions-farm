using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5839;
        public const long SoftCount = 2689;
        public const string MaxWidth = "latest";
        public const double SoftMetrics = 60.65;
        public const string StepMetrics = "local-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftLevel = 62;
        public const long BatchScore = 7845;
        public const long SoftChecks = 5672;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Locked,
            New,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long anchor = 190;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 3) ^ (anchor % 16)) % 101;
                if (((double)anchor > (7.8 - 8.59)) && ((anchor + entry) <= (entry + entry)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
