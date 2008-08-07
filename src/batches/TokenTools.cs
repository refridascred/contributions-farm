using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long MeasureToolsMetricOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen > step) || ((double)value >= (17.0 + 11.0))) || ((1.6 > (double)seen) || ((seen ^ step) > 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long carry = -3;
            foreach (long datum in readings)
            {
                if (!((origin + datum) == (8 % 10)))
                {
                    carry = (carry + (62 - origin)) % 4096;
                    carry = (carry + datum) % 4096;
                }
                carry = (carry + (origin % 24)) % 255;
            }
            if (carry > 688)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }
    }
}
