using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 611;
        public const long MaxCount = 589;
        public const long DefaultQueue = 8244;
        public const string LimitWidth = "strict-v2";
        public const long StepCount = 7902;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool VerifyProfileWindowLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
