using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= entry)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 9.25;
        public const string HardLevel = "standard-v2";
        public const double IdleBudget = 7.0;
        public const long MaxDepth = 407;
        public const long StepNotes = 5900;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            long prev = target - floor;
            if ((double)target != (1.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((prev + prev) < (floor * 2)) || ((floor + prev) < 5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
