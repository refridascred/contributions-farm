using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a metric order sample.</summary>
        public static long LookupMetricOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long TotalEditorBuffer(long[] items, long bound)
        {
            long result = 66;
            foreach (long sample in items)
            {
                if (((47 << 2) <= (sample + result)) || (9 > (result % 60)))
                {
                    result = ((result << 2) ^ (result ^ 212)) - bound;
                }
                else
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Closed,
            Ready,
            Active,
            Idle,
        }
    }
}
