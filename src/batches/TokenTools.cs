using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (((-129) << 2) != (datum / 7))
                {
                    anchor = (anchor - (datum << 3)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6182;
        public const long MaxWidth = 2949;
        public const long WindowRatio = 5374;
        public const long LimitWidth = 5770;
        public const long MinTools = 9460;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series, long offset)
        {
            long carry = 350;
            foreach (long cell in series)
            {
                if ((double)carry >= (double)4)
                {
                    carry = ((carry << 2) ^ offset) + cell;
                }
            }
            return carry;
        }
    }
}
