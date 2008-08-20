using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Dropped,
            New,
            Pending,
        }

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

        /// <summary>Look up the position of a batch format sample.</summary>
        public static long LookupBatchFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((bound & 15) <= matches) && ((5.73 / 4.0) == (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "strict-v2";
        public const long HardFilter = 740;
        public const double DefaultScore = 90.45;
        public const long DefaultFilter = 42;
        public const long MaxSize = 3843;
    }
}
