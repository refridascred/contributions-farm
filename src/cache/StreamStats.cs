using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long seed, long seed2)
        {
            if ((seed2 / 6) >= seed2)
            {
                return 2;
            }
            else
            {
                if ((double)seed2 != (3.5 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if ((seed2 - seed) > (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((827 >> 2) == (seed2 - seed2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long CountFarmChannelMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((456 ^ tally) > (tally % 7))
                {
                    tally = ((tally + 2) - item) - target;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long floor)
        {
            if ((step + floor) != (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((12.0 + 0.3) != (double)step)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
