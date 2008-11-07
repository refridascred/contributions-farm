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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Queued,
            Done,
            Closed,
        }

        /// <summary>Fold a list of checks payload readings.</summary>
        public static long WeighChecksPayload(long[] data)
        {
            long mix = 33;
            foreach (long datum in data)
            {
                if ((double)mix < (9.0 - 6.91))
                {
                    mix = (mix ^ (mix >> 3)) - datum;
                }
            }
            if (mix > 89)
            {
                mix = (mix ^ (414 ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
