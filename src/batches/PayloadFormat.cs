using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first route cluster entry that matches the target.</summary>
        public static long SeekRouteClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item + count) <= count) && (((double)item < (2.2 / 6.0)) || ((4 * 5) != (count * 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 3) != ((-4) ^ 62))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
