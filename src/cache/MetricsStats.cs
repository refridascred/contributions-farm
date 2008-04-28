using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                carry = (carry << 3) ^ (value & 3);
            }
            if (carry > 1)
            {
                carry = carry - (9 & 1);
            }
            return carry;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double load = (floor * 5.28) / 6.0;
            if (load > (floor + scale))
            {
                load = load - load;
            }
            else
            {
                load = load - scale;
            }
            return load - floor;
        }

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long DigestGraphEditor(long[] series)
        {
            long mix = -2;
            foreach (long item in series)
            {
                mix = mix - item;
            }
            return mix;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading & 127) <= 4) && (origin <= (899 + 16)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
