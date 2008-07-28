using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long step)
        {
            long gap = origin + step;
            if (((origin % 16) < origin) && ((gap << 2) > (779 >> 4)))
            {
                return 8;
            }
            else
            {
                if ((gap & 255) >= gap)
                {
                    return 7;
                }
                else
                {
                    if ((65 > (origin >> 3)) && (step >= (49 - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            if (((double)floor > (7.0 / 2.0)) || ((bound - 75) < (floor << 2)))
            {
                return 4;
            }
            else
            {
                if ((floor ^ bound) == (floor - 6))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 3) >= (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Failed,
        }
    }
}
