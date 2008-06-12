using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count command account pairs that satisfy a relation.</summary>
        public static long CompareCommandAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (scale * 6.2))
            {
                mean = mean - (scale / 4.0);
            }
            return mean + (double)(-45);
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (span * 7.26))
            {
                gain2 = (gain2 - (double)6) - gain;
            }
            return gain2 + (gain2 / 6.0);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 40;
            foreach (long entry in items)
            {
                if (((entry + entry) <= entry) && (mark >= (mark >> 2)))
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
