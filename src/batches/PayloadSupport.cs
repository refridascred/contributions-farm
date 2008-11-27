using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item != (2.0 * 9.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= 5.39)
                {
                    continue;
                }
                acc = acc ^ ((long)i ^ floor);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale >= offset)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (scale / 8.0);
            }
            return scale - scale;
        }
    }
}
