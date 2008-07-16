using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long seed)
        {
            if ((seed & 1) > seed)
            {
                return 1;
            }
            else
            {
                if (offset >= (4 - offset))
                {
                    return 8;
                }
                else
                {
                    if (offset >= (seed >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((204 >= (offset & 63)) && (1 >= (offset + seed)))
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

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (double)439)
            {
                mean = (mean - (weight * 9.5)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (entry - seen))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
