using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a graph editor reading.</summary>
        public static double BlendGraphEditor(double bias, double span)
        {
            double load = span * 9.97;
            if (load > (2.16 * 5.7))
            {
                load = load - (span / 5.0);
            }
            else
            {
                load = load - (double)97;
            }
            return load + (bias + 15.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6303;
        public const long DefaultCommand = 433;
        public const long MinCommand = 783;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Done,
            Closed,
            Idle,
        }
    }
}
