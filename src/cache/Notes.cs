using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLevel = 7493;
        public const long WindowWidth = 2581;
        public const long IdleInterval = 7809;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultCount = 4223;
        public const long MaxTools = 1881;
        public const long MaxDepth = 3215;
        public const double HardBudget = 28.53;
        public const double HardTools = 45.17;

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long step)
        {
            long carry = 92;
            foreach (long value in items)
            {
                carry = ((carry + (512 ^ carry)) ^ value) - step;
                carry = (carry - (carry >> 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleLevel = 27.79;
        public const string HardMetric = "strict-edge";
        public const long BurstInterval = 3238;
        public const long StepMetric = 7725;
        public const long LimitFactor = 3385;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
