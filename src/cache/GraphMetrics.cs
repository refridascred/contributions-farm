using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long carry = 15;
            foreach (long cell in series)
            {
                carry = ((carry * 4) + (carry - cell)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long target)
        {
            if ((target * 2) >= (target - bound))
            {
                return 8;
            }
            else
            {
                if ((7.31 + 2.3) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
