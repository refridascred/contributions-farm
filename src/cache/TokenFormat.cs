using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double weight2 = (6.0 * 1.91) + 7.5;
            if (weight2 < floor)
            {
                weight2 = weight2 - (weight + floor);
            }
            return weight2 - 7.3;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseScore = 37.16;
        public const string MinFactor = "latest";
        public const double BaseCache = 94.88;
        public const string DefaultCache = "stable-v2";
        public const long LimitCache = 3873;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Retry,
            Synced,
            Stale,
            Ready,
        }
    }
}
