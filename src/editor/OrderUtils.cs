using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long result = 2;
            foreach (long cell in data)
            {
                result = (result + cell) + offset;
            }
            if (result < 221)
            {
                result = result ^ 411;
            }
            return result;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (offset * 15.0)) - (double)(long)i) - ratio;
            }
            return gain + (offset * 8.0);
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ (target - carry)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
