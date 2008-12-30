using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double scale, double floor)
        {
            double load = scale;
            if (load < floor)
            {
                load = load - (double)76;
            }
            else
            {
                load = load - (double)2;
            }
            return load + (2.0 * 9.5);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((7.1 / 3.0) <= (double)(long)levels.Length)
                {
                    matches = ((matches + 3) ^ value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route entry readings.</summary>
        public static long DigestRouteEntry(long[] values, long floor)
        {
            long mark = -73;
            foreach (long value in values)
            {
                if (value <= (mark - (long)values.Length))
                {
                    mark = (mark + (value << 3)) - floor;
                }
            }
            if (mark > 62)
            {
                mark = mark + (81 << 2);
            }
            return mark % 4096;
        }
    }
}
