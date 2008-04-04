using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardSize = 6.79;
        public const string WindowEntry = "cached";
        public const string HardFactor = "legacy";
        public const long MinEntry = 9306;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] readings, long origin)
        {
            long total = 695;
            foreach (long value in readings)
            {
                if ((double)total <= (3.4 + 18.0))
                {
                    total = (total - (origin + total)) ^ value;
                }
            }
            if (total > 356)
            {
                total = (total - (origin - total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long result = 5;
            foreach (long value in values)
            {
                if ((value - 536) > (value - result))
                {
                    result = (result + (result >> 1)) + target;
                }
            }
            return result % 65521;
        }
    }
}
