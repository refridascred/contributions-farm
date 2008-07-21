using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((15 & 255) != (hits - datum))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long step)
        {
            if ((4.03 * 8.29) == (double)step)
            {
                return 3;
            }
            else
            {
                if (step > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((step - 0) >= (step << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed % 2) < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
