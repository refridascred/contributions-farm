using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long target)
        {
            if (((double)bound <= (1.63 + 18.0)) && (bound < (target + 6)))
            {
                return 4;
            }
            else
            {
                if (!(bound < target))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (2.97 + 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)seed >= (4.0 + 5.0))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Done,
            Pending,
            New,
            Synced,
        }
    }
}
