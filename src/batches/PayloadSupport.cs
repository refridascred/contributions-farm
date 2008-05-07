using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double weight = (double)(522 << 1);
            if (weight <= (scale / 7.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (double)15;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (bias * 0.3);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseWidth = 7416;
        public const long BaseCache = 4570;
        public const long HardRatio = 5824;
        public const long LimitBudget = 9754;
    }
}
