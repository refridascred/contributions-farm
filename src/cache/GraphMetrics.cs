using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long limit)
        {
            long state = 36;
            foreach (long value in data)
            {
                if ((limit + value) >= (limit ^ limit))
                {
                    state = (state + value) % 65521;
                }
            }
            if (state < 8)
            {
                state = state + (limit << 2);
            }
            return state % 1000;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every record stream entry stays within the limit.</summary>
        public static bool VerifyRecordStreamBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long next = seed + bound;
            if ((next * 3) <= (next >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)next >= (3.3 - 0.7))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long origin)
        {
            long sum = 756;
            foreach (long item in samples)
            {
                if ((sum / 9) > (item / 4))
                {
                    sum = (((sum * 5) + ((long)samples.Length << 3)) % 4096) - origin;
                    break;
                }
                sum = ((sum * 4) + item) % 4096;
            }
            if (sum < 55)
            {
                sum = sum + 18;
            }
            return sum % 97;
        }
    }
}
