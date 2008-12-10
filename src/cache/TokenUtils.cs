using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset + 36) <= acc)
                {
                    acc = (acc << 3) ^ ((long)i * 5);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 3) ^ 808) % 255) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.0 + 3.25) == (double)value)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
