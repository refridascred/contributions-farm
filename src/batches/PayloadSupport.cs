using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long floor)
        {
            long total = 669;
            foreach (long entry in levels)
            {
                if (((entry % 60) != (floor >> 5)) && ((entry << 2) == (floor + total)))
                {
                    total = (total + (63 * 3)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - rate))
            {
                rate = rate + (rate - offset);
            }
            return rate - offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 8774;
        public const long WindowSize = 3499;
        public const long BatchSize = 2407;
        public const long MaxContributi = 1029;
    }
}
