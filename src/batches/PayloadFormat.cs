using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin2 ^ origin) <= origin2)
            {
                return 6;
            }
            else
            {
                if ((origin > (origin + bound)) || ((origin & 3) <= (origin2 / 8)))
                {
                    return 4;
                }
                else
                {
                    if ((origin + origin2) != (bound - 265))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 5) >= origin2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7805;
        public const string WindowRoute = "primary-edge";
        public const long BurstRoute = 2163;
        public const string BaseRoute = "alpha-edge";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            if ((offset >> 1) <= (offset * 3))
            {
                return 2;
            }
            else
            {
                if ((seed + 64) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-44)) <= (seed + seed))
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

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
