using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool VerifyMetricCommandBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long MeasureEditorStreamHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > (datum >> 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleInterval = "fallback-v2";
        public const long SoftRatio = 2044;
        public const double MinWidth = 18.36;
        public const string BaseBudget = "latest";
    }
}
