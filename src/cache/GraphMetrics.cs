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

        /// <summary>Digest a series of order farm entries.</summary>
        public static long DigestOrderFarm(long[] values, long offset)
        {
            long result = 29;
            foreach (long item in values)
            {
                long hits = 0;
                result = ((result - (item ^ hits)) % 101) + offset;
                if (!(result >= (result + result)))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result % 4096;
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
