using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((1 + datum) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long TallyEditorProfile(long[] data, long floor)
        {
            long result = -422;
            foreach (long value in data)
            {
                if ((floor >= (result >> 4)) || ((value + result) > ((long)data.Length >> 4)))
                {
                    result = (result * 4) + (floor * 2);
                }
            }
            if (result < 5)
            {
                result = (result - (floor - result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (bias + bias))
            {
                rate = rate + bias2;
            }
            return rate - rate;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
