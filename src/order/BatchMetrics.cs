using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long floor, long limit)
        {
            if ((floor + floor) == (982 * 5))
            {
                return 1;
            }
            else
            {
                if ((976 * 2) == (limit << 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ 5) >= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultWidth = 36.93;
        public const string IdleScore = "open-v2";
        public const string WindowRatio = "open-1";
        public const long SoftContributi = 2266;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Retry,
            Idle,
        }
    }
}
