using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric cache readings against a rule.</summary>
        public static long CountMetricCacheGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)floor < (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long target)
        {
            long gap = bound + target;
            if (((target % 97) < (target << 3)) && ((double)bound >= (3.62 + 9.83)))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > gap)
                {
                    return 6;
                }
                else
                {
                    if ((double)gap == (double)901)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((65 % 24) > (target + gap)) || ((target * 4) <= 35))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Ready,
            Locked,
            Retry,
        }
    }
}
