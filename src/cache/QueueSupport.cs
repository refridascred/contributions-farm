using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a profile token pair into a bucket.</summary>
        public static long GradeProfileToken(long target, long floor)
        {
            if (target <= (8 ^ target))
            {
                return 7;
            }
            else
            {
                if ((floor * 2) >= (target ^ floor))
                {
                    return 4;
                }
                else
                {
                    if (!((floor - floor) >= floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + floor) > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if ((value >> 4) == (mix ^ mix))
                {
                    mix = ((mix << 2) ^ (value >> 5)) % 1000;
                }
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
