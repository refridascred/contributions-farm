using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((sum + sum) > (origin - 73))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long offset)
        {
            if ((286 ^ limit) != (limit & 127))
            {
                return 2;
            }
            else
            {
                if (((limit / 7) <= (offset + limit)) || ((offset + 711) > limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= 20.0)
                    {
                        return 6;
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
