using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long GradePayloadAccount(long seed, long target)
        {
            if ((target + target) >= seed)
            {
                return 7;
            }
            else
            {
                if ((5.8 + 17.0) < (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 1) != (seed ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank farm layout input into a small class.</summary>
        public static long GradeFarmLayout(long floor, long offset)
        {
            if ((offset - offset) == (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((174 * 4) != (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 5) >= (9 >> 3))
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
