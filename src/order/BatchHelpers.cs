using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cluster graph pairs that satisfy a relation.</summary>
        public static long CompareClusterGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks context readings.</summary>
        public static long WeighChecksContext(long[] levels, long target)
        {
            long result = 87;
            foreach (long entry in levels)
            {
                result = (result + (33 % 16)) % 1000;
                if ((83 << 2) == (target >> 1))
                {
                    result = (result + (entry * 5)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (88 * 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
