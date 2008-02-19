using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((tally - (-410)) == (tally + tally)) && ((sample + sample) == (tally + tally))) || !((tally + tally) == (sample - sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long bound, long floor)
        {
            long edge = bound - floor;
            if (!((edge + floor) >= (floor & 1)))
            {
                return 5;
            }
            else
            {
                if ((5.1 - 0.36) <= (double)edge)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > 8.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((edge >> 4) < (bound + 6)) && ((floor * 2) <= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Queued,
        }
    }
}
