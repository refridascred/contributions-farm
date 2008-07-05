using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            long slot = seed + offset;
            if ((offset * 2) != ((-886) << 1))
            {
                return 2;
            }
            else
            {
                if ((slot + slot) <= seed)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a metric cluster sample.</summary>
        public static long LookupMetricClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
