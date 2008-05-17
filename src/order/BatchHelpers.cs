using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a tools contributi sample.</summary>
        public static long LocateToolsContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (count * 2))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
