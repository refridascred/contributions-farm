using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
