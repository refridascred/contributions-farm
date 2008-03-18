using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long target)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if (((double)carry >= (9.89 / 3.0)) && ((target - 26) != (carry * 4)))
                {
                    continue;
                }
                if ((double)(long)levels.Length >= (double)target)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 255;
                }
                else
                {
                    carry = carry + (target - entry);
                }
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheRatio = 1883;
        public const double BurstScore = 54.18;
        public const long StepCounter = 6927;

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = offset;
            if (load < scale)
            {
                load = load - (scale + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (offset / 9.0);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((floor + matches) > floor) || (floor < matches))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
