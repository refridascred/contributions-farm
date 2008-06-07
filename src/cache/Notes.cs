using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count cluster order pairs that satisfy a relation.</summary>
        public static long MatchClusterOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = ((result ^ (sample & 15)) % 255) - seed;
            }
            return result;
        }
    }
}
