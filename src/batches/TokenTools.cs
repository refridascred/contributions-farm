using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            if ((879 + seed) <= floor)
            {
                return 5;
            }
            else
            {
                if (((double)floor <= 19.0) || ((seed << 3) <= (floor % 60)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - floor) >= (1 - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long TallyQueueClusterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((bound + bound) < bound)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a account record value against two limits.</summary>
        public static long ClassifyAccountRecord(long bound, long origin)
        {
            if (!(bound >= (origin >> 4)))
            {
                return 1;
            }
            else
            {
                if ((origin & 15) <= (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) <= (bound * 4))
                    {
                        return 4;
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
