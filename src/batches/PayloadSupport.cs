using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (acc - seed)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (origin <= target)
            {
                return 8;
            }
            else
            {
                if (((target - origin) <= origin) || ((target % 2) < (67 + target)))
                {
                    return 4;
                }
                else
                {
                    if ((4.8 - 3.44) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target * 3) < (target + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
