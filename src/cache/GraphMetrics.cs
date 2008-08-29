using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit schema metric readings against a rule.</summary>
        public static long CountSchemaMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample - (long)levels.Length) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Rank schema metric input into a small class.</summary>
        public static long ClassifySchemaMetric(long offset, long offset2)
        {
            if (((offset2 + offset2) > offset) && ((double)offset2 > 8.5))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) > 7)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long CountSessionQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 3) > count)
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter command entries.</summary>
        public static long WeighCounterCommand(long[] data)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length > (double)312)
                {
                    state = (state ^ (sample / 3)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
