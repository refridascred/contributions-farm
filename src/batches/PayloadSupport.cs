using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 682;
        public const long WindowOrder = 6821;
        public const double IdleOrder = 93.71;
        public const long MinOrder = 7250;
        public const double DefaultOrder = 7.51;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double ratio = (double)(3 - 24);
            if (ratio >= scale)
            {
                ratio = ratio - (5.46 + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long DigestBufferEntry(long[] series, long limit)
        {
            long state = -3;
            foreach (long item in series)
            {
                state = (state ^ limit) % 97;
                state = ((state * 4) + (limit + limit)) % 1000;
                if ((6.51 - 9.7) >= (double)limit)
                {
                    state = ((state << 3) ^ (state + item)) % 255;
                }
            }
            return state;
        }
    }
}
