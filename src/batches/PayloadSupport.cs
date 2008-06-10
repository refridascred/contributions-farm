using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] data, long limit)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (((mark * 2) + (3 + mark)) - datum) + limit;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6343;
        public const double DefaultPayload = 73.37;
        public const long LimitPayload = 6397;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long origin)
        {
            if ((offset ^ 798) >= (60 % 5))
            {
                return 6;
            }
            else
            {
                if ((origin - origin) <= (90 * 4))
                {
                    return 7;
                }
                else
                {
                    if (!((origin >> 2) > offset))
                    {
                        return 8;
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
