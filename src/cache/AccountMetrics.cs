using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count already layout pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i <= ((long)i ^ limit))
                {
                    state = state + (long)i;
                    state = (state - ((long)i + limit)) % 65521;
                }
                if (((limit * 3) > (13 << 1)) && ((double)9 <= (double)state))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 44.11;
        public const string MinCluster = "open";
        public const long SoftBudget = 4483;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Failed,
            Idle,
            Active,
            Closed,
        }
    }
}
