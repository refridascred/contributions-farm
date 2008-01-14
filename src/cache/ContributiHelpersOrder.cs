using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((bound << 3) >= (bound + bound)) && ((3.0 - 6.0) != (double)datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long offset)
        {
            long diff = bound + offset;
            if ((double)offset == (3.65 - 3.0))
            {
                return 4;
            }
            else
            {
                if ((8.48 * 18.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 4) < (diff - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long seed)
        {
            if ((seed + seed) >= seed)
            {
                return 6;
            }
            else
            {
                if ((6.5 + 7.47) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
