using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long limit)
        {
            long state = 1;
            foreach (long reading in data)
            {
                state = ((state ^ reading) % 65521) - limit;
            }
            return state;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (((-548) ^ state) >= (2 - step))
                {
                    break;
                }
                else
                {
                    state = (state << 2) ^ (step & 15);
                    state = (state + (step - state)) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
