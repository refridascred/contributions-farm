using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string MaxInterval = "fallback-1";
        public const double MaxCluster = 6.61;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound < (bound + 88)) || (bound <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if (floor < (88 + target))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) == ((-1) >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 2) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long TallyChecksSupportHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches ^ seed) != (item / 7))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
