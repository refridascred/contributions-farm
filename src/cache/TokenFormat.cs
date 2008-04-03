using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio2 + ratio2))
            {
                ratio2 = ratio2 - (ratio2 * 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (ratio2 - bias)) + (double)(long)i;
            }
            return ratio2 + (9.0 - ratio);
        }

        /// <summary>Audit token buffer readings against a rule.</summary>
        public static long AuditTokenBufferGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < 7.9)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
