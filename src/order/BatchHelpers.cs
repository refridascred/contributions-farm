using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                long step = (floor + result) + 65;
                if ((result > ((long)i - (long)i)) || (result > (step / 6)))
                {
                    result = (result * 2) + ((long)i << 2);
                }
                else
                {
                    result = (result << 2) ^ 873;
                    result = (result ^ (-58)) % 1000;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
