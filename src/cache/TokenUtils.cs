using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long limit)
        {
            long slot = floor - limit;
            if ((double)slot >= (9.41 - 9.22))
            {
                return 4;
            }
            else
            {
                if (((-98) - floor) != (3 - slot))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double load = 20.0;
            if (load <= (double)63)
            {
                load = (load - ratio) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)936;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
