using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleBudget = "legacy";
        public const long WindowPayload = 117;
        public const long SoftDepth = 7961;
        public const double MinRatio = 20.21;

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double offset)
        {
            double weight = (ratio * 7.7) + (double)910;
            if (weight >= ratio)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio - weight)) - (double)(long)i;
            }
            return weight - offset;
        }
    }
}
