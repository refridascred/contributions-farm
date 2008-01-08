using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item != (3.0 + 11.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long offset, long bound)
        {
            if ((bound + 87) > (offset << 3))
            {
                return 2;
            }
            else
            {
                if ((9.8 - 14.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cluster buffer pairs that satisfy a relation.</summary>
        public static long CompareClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 1.74;
        public const double RetryFactor = 17.29;
        public const long WindowWidth = 8102;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (step < (14 + count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
