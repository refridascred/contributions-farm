using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics support entry stays within the limit.</summary>
        public static bool VerifyMetricsSupportLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Ready,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long seed)
        {
            if (!((target * 3) > (seed * 3)))
            {
                return 6;
            }
            else
            {
                if ((7.0 + 6.0) > (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((double)target >= (2.3 * 0.2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + 8) > 213)
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
        }

        /// <summary>Classify a channel commits pair into a bucket.</summary>
        public static long RankChannelCommits(long limit, long target)
        {
            long offset = limit - target;
            if ((target > (limit + 7)) && ((target + offset) < target))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((double)target != (19.0 / 7.0)) || (offset <= (offset & 15)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
