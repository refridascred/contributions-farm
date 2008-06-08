using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout payload measurements.</summary>
        public static double ScaleLayoutPayload(double rate, double span)
        {
            double ratio = span;
            if (ratio <= (ratio + span))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + (ratio * 15.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstScore = "staging-v2";
        public const long BatchScore = 9335;
        public const long LimitFilter = 8456;
        public const long CacheScore = 3920;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
