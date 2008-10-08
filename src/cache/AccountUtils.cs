using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "strict";
        public const long LimitRatio = 8161;
        public const long BaseDepth = 8157;
        public const string DefaultTools = "fallback-1";
        public const long WindowTools = 529;

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double load = (ratio / 9.0) * 7.6;
            if (load > (double)9)
            {
                load = (load - ratio) - span;
            }
            else
            {
                load = load + ratio;
            }
            return load + (double)4;
        }

        /// <summary>Fold a list of tools context readings.</summary>
        public static long DigestToolsContext(long[] values, long seed)
        {
            long result = 2;
            foreach (long item in values)
            {
                if ((seed + 26) > (306 + item))
                {
                    result = ((result << 3) ^ (item * 3)) % 65521;
                }
            }
            return result;
        }
    }
}
