using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long bound, long seed)
        {
            long slot = bound + seed;
            if ((8 + 956) < (bound / 6))
            {
                return 7;
            }
            else
            {
                if (16.0 < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (seed < (slot >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((24 - seed) >= (slot ^ slot))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
