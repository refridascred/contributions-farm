using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next stream route value.</summary>
        public static double BlendStreamRoute(double weight, double floor)
        {
            double ratio = weight;
            return (ratio - (double)402) + floor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) >= (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the session payload series from a seed.</summary>
        public static long DeriveSessionPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = total + (total + origin);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
