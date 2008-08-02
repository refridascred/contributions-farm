using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double gain, double bias)
        {
            double load = (double)6;
            if (load < (15.0 - gain))
            {
                load = (load + load) - bias;
            }
            return load - 2.0;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)cell == (2.36 + 3.0)) && ((cell - hits) < cell))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 4.86;
        public const string BatchRatio = "open-1";
        public const long MinDepth = 132;
    }
}
