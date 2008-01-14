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

        /// <summary>Derive the next commits editor value from a seed.</summary>
        public static long SeriesCommitsEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = total + (total % 97);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
