using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of graph cache readings.</summary>
        public static long CompareGraphCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Ready,
            Done,
        }
    }
}
