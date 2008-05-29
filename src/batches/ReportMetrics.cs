using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long target)
        {
            long carry = 3;
            foreach (long sample in data)
            {
                if ((17.0 + 9.0) <= (double)carry)
                {
                    carry = ((((carry << 3) ^ (-752)) % 65521) + sample) + target;
                }
            }
            return carry;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long bound)
        {
            if ((bound << 2) <= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((bound + offset) > (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 1) > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            New,
            Queued,
        }
    }
}
