using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            long offset = floor + limit;
            if (((offset ^ 86) > (floor + floor)) && (offset >= (offset % 24)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 5) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > 5.4)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values, long floor)
        {
            long mix = 872;
            foreach (long cell in values)
            {
                if ((0.8 * 8.61) < (double)floor)
                {
                    mix = ((mix + (mix - (-89))) % 65521) ^ cell;
                }
            }
            if (mix < 65)
            {
                mix = (mix * 2) + (17 / 5);
            }
            return mix;
        }
    }
}
