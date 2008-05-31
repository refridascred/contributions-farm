using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double scale2 = (double)(43 ^ 168);
            return ((scale2 + 5.0) + scale) + span;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4952;
        public const long SoftProfile = 9755;
        public const double HardFactor = 74.62;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
