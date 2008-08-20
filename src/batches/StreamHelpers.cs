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

        /// <summary>Derive the next order notes value from a seed.</summary>
        public static long SeriesOrderNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                long offset = (long)i;
                state = state ^ offset;
                if (!((offset / 6) != (offset * 2)))
                {
                    offset = ((offset * 5) + (916 * 5)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
