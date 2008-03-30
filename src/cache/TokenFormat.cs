using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepDepth = 4999;
        public const double HardInterval = 30.68;
        public const long CacheWidth = 2442;
        public const double BaseBatch = 58.49;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double ratio = (double)(393 << 2);
            if (ratio < weight)
            {
                ratio = (ratio + 4.53) + offset;
            }
            return ratio - (double)1;
        }

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool GuardEditorAlreadyRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
