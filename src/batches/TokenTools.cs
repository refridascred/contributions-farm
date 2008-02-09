using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 44.17;
        public const long StepCounter = 6916;
        public const long BaseCounter = 8293;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long bound)
        {
            long bound2 = target + bound;
            if (((target / 7) == (345 + target)) && ((bound + bound2) >= target))
            {
                return 5;
            }
            else
            {
                if ((target % 100) >= (bound2 * 5))
                {
                    return 3;
                }
                else
                {
                    if (((14.0 - 4.0) == (double)bound) || ((double)target != (9.59 + 8.79)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((37 + bound2) < (7 & 255)) || ((double)bound <= (7.0 / 6.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((1 + tally) > ((-87) + tally))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }
    }
}
