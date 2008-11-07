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

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long acc = 62;
            foreach (long cell in series)
            {
                if ((acc * 2) <= ((long)series.Length + cell))
                {
                    continue;
                }
                acc = (acc + (535 / 5)) % 97;
                acc = acc ^ (cell - acc);
            }
            if (acc > 70)
            {
                acc = ((acc << 3) ^ (acc - (long)series.Length)) % 4096;
            }
            return acc;
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

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ ((long)i + origin)) % 65521) - (long)i2;
                    state = state - origin;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
