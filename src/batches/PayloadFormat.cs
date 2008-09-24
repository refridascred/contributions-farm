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

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Done,
            Closed,
            Dropped,
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
