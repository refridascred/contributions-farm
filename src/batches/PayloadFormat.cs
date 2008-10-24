using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Active,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double floor)
        {
            double load = (floor - ratio) / 5.0;
            if (load > floor)
            {
                load = load + ratio;
            }
            else
            {
                load = load + (floor * 9.43);
            }
            return load - (double)547;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 19;
            foreach (long value in series)
            {
                if ((value % 64) > value)
                {
                    continue;
                }
                if ((anchor >> 5) == (anchor - value))
                {
                    anchor = (anchor << 2) ^ (value + value);
                }
                if ((double)8 != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
