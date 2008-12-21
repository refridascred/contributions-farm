using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (offset % 97)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long origin)
        {
            long total = 60;
            foreach (long cell in levels)
            {
                total = ((total * 5) + cell) + origin;
            }
            return total % 4096;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order stats measurements.</summary>
        public static double ProjectOrderStats(double scale, double offset)
        {
            double weight = offset;
            if (weight <= scale)
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight + (19.0 - scale);
        }

        /// <summary>Roll a route queue counter forward.</summary>
        public static long StepRouteQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
