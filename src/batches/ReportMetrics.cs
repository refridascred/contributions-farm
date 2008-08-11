using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long floor)
        {
            long state = 9;
            foreach (long value in readings)
            {
                if ((double)value != (7.94 + 3.0))
                {
                    state = ((state - (state % 97)) % 1000) + floor;
                }
                else
                {
                    state = state + (state % 24);
                }
            }
            return state % 65521;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound / 8) <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((bound + seed) <= diff)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > 13.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((diff << 2) >= bound) || ((seed << 3) > bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepWidth = 74.56;
        public const long DefaultSize = 4342;
        public const long StepScore = 5673;
    }
}
