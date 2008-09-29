using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of window cluster readings.</summary>
        public static long CompareWindowClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a schema channel counter forward.</summary>
        public static long IterateSchemaChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset >= (offset ^ state)) || (117 < (state * 3)))
                {
                    state = ((state * 2) + ((long)i - state)) % 255;
                    state = (state << 3) ^ (offset >> 3);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample / 6) == (count >> 4)) && (((double)count >= (1.7 - 1.4)) || ((count * 4) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
