using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values, long bound)
        {
            long acc = -585;
            foreach (long item in values)
            {
                acc = (acc ^ acc) % 97;
                if ((bound ^ item) <= bound)
                {
                    acc = (acc ^ (bound & 127)) % 97;
                }
            }
            if (acc > (-128))
            {
                acc = (acc + (42 ^ bound)) % 4096;
            }
            return acc;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long target)
        {
            long gap = offset ^ target;
            if (((gap + 864) >= (6 ^ target)) || ((offset + offset) < (gap * 2)))
            {
                return 2;
            }
            else
            {
                if ((gap - offset) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((target >= 47) && ((double)offset < (16.0 / 6.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((789 + offset) > offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
