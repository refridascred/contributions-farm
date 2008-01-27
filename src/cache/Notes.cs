using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 41.05;
        public const string SoftCount = "primary-v2";
        public const long StepWidth = 9922;
        public const long RetryCommits = 2243;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long floor, long origin)
        {
            long diff = floor - origin;
            if (((3.91 + 4.0) <= (double)diff) && ((origin % 60) == (643 + 23)))
            {
                return 4;
            }
            else
            {
                if ((4.92 * 13.0) >= (double)diff)
                {
                    return 0;
                }
                else
                {
                    if (diff < (origin & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
