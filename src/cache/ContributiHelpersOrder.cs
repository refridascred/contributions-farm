using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (4.0 >= (double)seed)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "legacy-v2";
        public const long LimitDepth = 5280;
        public const long IdleContext = 4688;
        public const long IdleWidth = 5329;
        public const double RetryContext = 51.37;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long bound)
        {
            if ((bound << 1) != (bound + offset))
            {
                return 4;
            }
            else
            {
                if ((4 - 171) > offset)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (offset / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 3) >= (offset + 401))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
