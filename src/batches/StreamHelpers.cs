using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8134;
        public const long MinRatio = 7628;
        public const double HardCommits = 33.07;
        public const double RetryCommits = 37.36;
        public const long MaxCommits = 6362;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum == (7.68 - 5.6)))
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = (sum ^ (datum - 183)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long IterateLayoutBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state + (state << 2);
                if (!(((long)i / 9) >= state))
                {
                    state = (state + (long)i) % 65521;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Pending,
            Locked,
            Draft,
        }
    }
}
