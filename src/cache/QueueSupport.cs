using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit payload counter readings against a rule.</summary>
        public static long MeasurePayloadCounterGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9 >> 3) < entry)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            long bound = target ^ seed;
            if (!((target << 1) == (seed ^ seed)))
            {
                return 1;
            }
            else
            {
                if ((double)target < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((target << 2) == (seed << 2)) || ((target + seed) >= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 1) >= (target * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
