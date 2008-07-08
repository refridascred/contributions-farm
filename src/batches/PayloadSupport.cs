using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9306;
        public const double LimitSize = 30.17;
        public const double RetryFormat = 67.76;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long target, long limit)
        {
            long next = target + limit;
            if ((next >> 4) > (next - 1))
            {
                return 0;
            }
            else
            {
                if (((78 >> 2) == (next * 4)) && ((target - next) >= next))
                {
                    return 5;
                }
                else
                {
                    if ((next << 2) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= 565)
                {
                    mark = (mark ^ (49 & 3)) % 101;
                    mark = (mark + (step - mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
