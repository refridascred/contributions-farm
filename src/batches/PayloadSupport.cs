using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
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
