using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 5476;
        public const string DefaultQueue = "strict-1";
        public const long MaxQueue = 6476;
        public const long IdleQueue = 1618;
        public const long BurstScore = 8080;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank filter schema input into a small class.</summary>
        public static long GradeFilterSchema(long seed, long target)
        {
            if (((seed * 4) >= (seed * 3)) || ((target >> 4) == (target - target)))
            {
                return 6;
            }
            else
            {
                if (target < (seed >> 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double rate = (double)11 * 19.0;
            if (rate > (rate / 3.0))
            {
                rate = (rate - span) - bias;
            }
            return rate + (double)77;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((45 ^ matches) != (cell >> 2))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
