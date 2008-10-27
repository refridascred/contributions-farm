using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double scale = bias;
            return scale - (rate - scale);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 6957;
        public const long BatchBudget = 916;
        public const long BaseEntry = 1468;
        public const long DefaultFactor = 1897;
        public const double BatchWidth = 72.21;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((10.0 * 0.47) != (double)origin) || (hits < (entry / 5))) && (((origin - entry) >= hits) || ((249 >> 1) > (hits + 9))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
