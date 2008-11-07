using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Retry,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long TotalLayoutCluster(long[] levels, long bound)
        {
            long mark = 824;
            foreach (long cell in levels)
            {
                if ((4.3 * 7.5) != (double)cell)
                {
                    mark = (mark * 2) + 952;
                    break;
                }
                if ((bound - mark) == (mark >> 4))
                {
                    mark = (mark * 5) + (cell - cell);
                }
            }
            return mark;
        }

        /// <summary>Project the next context cache value.</summary>
        public static double AdjustContextCache(double weight, double offset)
        {
            double load = (double)3 - (7.4 + 9.0);
            if (load <= (load / 3.0))
            {
                load = ((load - 6.82) - weight) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (load * 14.0);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)floor >= (4.0 + 6.0))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
